using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class HoneywellTest
    {
        class MovieData
        {
            public string Poster { get; set; }
            public string Title { get; set; }
            public string Type { get; set; }
            public int Year { get; set; }
            public string imdbID { get; set; }

        }
        class MainResponse
        {
            public int Page { get; set; }
            public int Per_Page { get; set; }
            public int Total { get; set; }
            public int Total_Pages { get; set; }
            public MovieData[] Data { get; set; }
        }
        /*
         * Complete the function below. 
         */
        public static string[] getMovieTitlesAsync(string substr)
        {
            List<string> movies = new List<string>();
            HttpResponseMessage response = GetResponse(substr);
            if (response.IsSuccessStatusCode)
            {
                var res = response.Content.ReadAsStringAsync().Result;
                dynamic mainResponse = JObject.Parse(res);
                foreach (dynamic movie in mainResponse.data)
                {
                    movies.Add(movie.title);
                }
                for (int i = 2; i <= int.Parse(mainResponse.total_pages.Value.ToString()); i++)
                {
                    response = GetResponse(substr, i);
                    //mainResponse = response.Content.ReadAsAsync<MainResponse>().Result;
                    res = response.Content.ReadAsStringAsync().Result;
                    mainResponse = JObject.Parse(res);

                    foreach (dynamic movie in mainResponse.data)
                    {
                        movies.Add(movie.title);
                    }
                }
                //Console.WriteLine(mainResponse.Total_Pages);
            }
            movies.Sort();
            return movies.ToArray();
        }

        private static HttpResponseMessage GetResponse(string substr, int pageNumber = 0)
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("https://jsonmock.hackerrank.com/api/movies/search");
            client.DefaultRequestHeaders.Accept.Clear();
            //client.DefaultRequestHeaders.Accept.Add("application/json");
            string urlParams = $"?Title={substr}";
            if (pageNumber != 0)
            {
                urlParams += "&page=" + pageNumber;
            }
            return client.GetAsync(urlParams).Result;
        }
    }
}
