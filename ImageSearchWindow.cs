using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Name_That_Logo_Game
{
    public partial class ImageSearchWindow : Form
    {
        private const string COUNT_PARAMETER = "&count=";
        private const string MKT_PARAMETER = "&mkt="; // Strongly suggested
        private const string QUERY_PARAMETER = "?q="; // Required
        private const string SAFE_SEARCH_PARAMETER = "&safeSearch=";
        private static readonly string _baseUri = "https://api.bing.microsoft.com/v7.0/images/search";
        private static readonly string _marketCode = "en-us";
        private static readonly string _subscriptionKey = "849552c6f7bd47e3b40b0f45789f2e97";
        private static readonly List<string> ImageUrls = new List<string>();
        private readonly List<string> ImageList;
        private string SafeSearchValue = "Moderate";
        public ImageSearchWindow()
        {
            InitializeComponent();
            ImageList = new List<string>();
        }

        public static async Task<List<string>> RunAsync(string searchString, int count, string safeSearch)
        {
            try
            {
                var queryString = QUERY_PARAMETER + Uri.EscapeDataString(searchString);
                queryString += MKT_PARAMETER + _marketCode;
                queryString += COUNT_PARAMETER + count;
                queryString += SAFE_SEARCH_PARAMETER + Uri.EscapeDataString(safeSearch);

                HttpResponseMessage response = await MakeRequestAsync(queryString);

                var contentString = await response.Content.ReadAsStringAsync();
                Dictionary<string, object> searchResponse = JsonConvert.DeserializeObject<Dictionary<string, object>>(contentString);

                if (response.IsSuccessStatusCode)
                {
                    PopulateImageList(searchResponse);
                }
                else
                {
                    PrintErrors(response.Headers, searchResponse);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            return ImageUrls;
        }

        public List<string> RetrieveImages()
        {
            return ImageList;
        }

        private static async Task<HttpResponseMessage> MakeRequestAsync(string queryString)
        {
            var client = new HttpClient();

            // Request headers. The subscription key is the only required header but you should
            // include User-Agent (especially for mobile), X-MSEdge-ClientID, X-Search-Location
            // and X-MSEdge-ClientIP (especially for local aware queries).

            client.DefaultRequestHeaders.Add("Ocp-Apim-Subscription-Key", _subscriptionKey);

            return await client.GetAsync(_baseUri + queryString);
        }

        private static void PopulateImageList(Dictionary<string, object> response)
        {
            ImageUrls.Clear();
            var images = response["value"] as Newtonsoft.Json.Linq.JToken;

            foreach (Newtonsoft.Json.Linq.JToken image in images)
            {
                ImageUrls.Add((string)image["contentUrl"]);
            }
        }

        private static void PrintError(Newtonsoft.Json.Linq.JToken error)
        {
            string value = null;

            Console.WriteLine("Code: " + error["code"]);
            Console.WriteLine("Message: " + error["message"]);

            if ((value = (string)error["parameter"]) != null)
            {
                Console.WriteLine("Parameter: " + value);
            }

            if ((value = (string)error["value"]) != null)
            {
                Console.WriteLine("Value: " + value);
            }
        }

        private static void PrintErrors(HttpResponseHeaders headers, Dictionary<String, object> response)
        {
            Console.WriteLine("The response contains the following errors:\n");

            object value;

            if (response.TryGetValue("error", out value))  // typically 401, 403
            {
                PrintError(response["error"] as Newtonsoft.Json.Linq.JToken);
            }
            else if (response.TryGetValue("errors", out value))
            {
                // Bing API error

                foreach (Newtonsoft.Json.Linq.JToken error in response["errors"] as Newtonsoft.Json.Linq.JToken)
                {
                    PrintError(error);
                }

                // Included only when HTTP status code is 400; not included with 401 or 403.

                IEnumerable<string> headerValues;
                if (headers.TryGetValues("BingAPIs-TraceId", out headerValues))
                {
                    Console.WriteLine("\nTrace ID: " + headerValues.FirstOrDefault());
                }
            }
        }

        private async void Button1_Click(object sender, EventArgs e)
        {
            var searchTerm = textBox1.Text;
            var count = (int)numericUpDown1.Value;

            var images = await RunAsync(searchTerm, count, SafeSearchValue);
            ImageList.AddRange(images);
            Close();
        }
        private void RadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (!(sender is RadioButton rb))
            {
                MessageBox.Show("Sender is not a RadioButton");
                return;
            }

            // Ensure that the RadioButton.Checked property
            // changed to true.
            if (rb.Checked)
            {
                // Keep track of the selected RadioButton by saving a reference
                // to it.
                SafeSearchValue = rb.Text;
            }
        }
    }
}