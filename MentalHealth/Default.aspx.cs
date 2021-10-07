using Microsoft.Ajax.Utilities;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MentalHealth
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string strurltest = String.Format("https://health.gov/myhealthfinder/api/v3/topicsearch.json?categoryId=20");
            WebRequest requestObjGet = WebRequest.Create(strurltest);
            requestObjGet.Method = "GET";
            HttpWebResponse responseObjGet = null;
            responseObjGet = (HttpWebResponse)requestObjGet.GetResponse();

            string strresulttest = null;
            using (Stream stream = responseObjGet.GetResponseStream())
            {
                StreamReader sr = new StreamReader(stream);
                strresulttest = sr.ReadToEnd();
                ValueSet items = JsonConvert.DeserializeObject<ValueSet>(strresulttest);
                Debug.WriteLine(items.Values + "********************************");
                //List<CreateUser> items = JsonConvert.DeserializeObject<List<CreateUser>>(strresulttest);
                sr.Close();
            }
        }
    }
    // class CreateUser
    // {
    //             public string Sections
    //}
    //class Wrapper
    //{
    //    [JsonProperty("JsonValues")]
    //    public ValueSet ValueSet { get; set; }
    //}
    class Value
    {
        [JsonProperty("section")]
        public string section { get; set; }

    }
    class ValueSet
    {
        [JsonProperty("Sections")]
        public Dictionary<string, Value> Values { get; set; }
    }

}