using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
namespace MentalHealth.Controllers
{
    public class MyController : ApiController
    {
        //public class Fact
        //{
        //    public string MentalHealthFact { get; set; }
        //}
        //// GET api/<controller>
        //static HttpClient client = new HttpClient();

        //static void ShowFact(Fact fact)
        //{
        //    Console.WriteLine($"Fact: {fact.MentalHealthFact}");
        //}
        //static async Task<Uri> CreateFactAsync(Fact fact)
        //{
        //    HttpResponseMessage response = await client.PostAsJsonAsync(
        //        "/topicsearch.json/categoryId,20", fact);
        //    response.EnsureSuccessStatusCode();

        //    // return URI of the created resource.
        //    return response.Headers.Location;
        //}
        //static async Task<Fact> GetFactAsync(string path)
        //{
        //    Fact fact = null;
        //    HttpResponseMessage response = await client.GetAsync(path);
        //    if (response.IsSuccessStatusCode)
        //    {
        //        fact = await response.Content.ReadAsAsync<Fact>();
        //    }
        //    return fact;
        //}
        //static void Main()
        //{
        //    Console.WriteLine("working***********************");
                
        //}

        //static async Task RunAsync()
        //{
        //    // Update port # in the following line.
        //    client.BaseAddress = new Uri("https://health.gov/myhealthfinder/api/v3");
        //    client.DefaultRequestHeaders.Accept.Clear();
        //    client.DefaultRequestHeaders.Accept.Add(
        //        new MediaTypeWithQualityHeaderValue("application/json"));

        //    try
        //    {
        //        Fact fact = new Fact
        //        {
        //            MentalHealthFact=""
        //        };
        //        var url = await CreateFactAsync(fact);
        //        Console.WriteLine($"Created at {url}");

        //        // Get the product
        //       fact = await GetFactAsync(url.PathAndQuery);
        //        ShowFact(fact);

        //    }
        //    catch (Exception e)
        //    {
        //        Console.WriteLine(e.Message);
        //    }

        //    Console.ReadLine();
        //}
    }
}