using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using System.Threading.Tasks;

namespace XamTrainBang
{
    public class NyServiceClient
    {
        public static string RestUrl = "http://api.nytimes.com/svc/news/v3/content/all/all/.json?api-key=ed158f7b2d2b97a8e611edb24db14d50%3A16%3A73866500";
        HttpClient client;
        public NyServiceClient()
        {
            client = new HttpClient();
            client.MaxResponseContentBufferSize = 256000;
        }

        public async Task<ServiceResult> GetStoryList()
        {
            ServiceResult vResult = null;
            try
            {
                var response = await client.GetAsync(RestUrl);
                if (response.IsSuccessStatusCode)
                {
                    var content = await response.Content.ReadAsStringAsync();
                    vResult = JsonConvert.DeserializeObject<ServiceResult>(content);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(@"	ERROR {0}", ex.Message);
            }
            return vResult;
        }





    }

    public class RelatedUrl
    {
        public string suggested_link_text { get; set; }
        public string url { get; set; }
    }

    public class Result
    {
        public string section { get; set; }
        public string subsection { get; set; }
        public string title { get; set; }
        public string @abstract { get; set; }
        public string url { get; set; }
        public string byline { get; set; }
        public string thumbnail_standard { get; set; }
        public string item_type { get; set; }
        public string source { get; set; }
        public string updated_date { get; set; }
        public string created_date { get; set; }
        public string published_date { get; set; }
        public string material_type_facet { get; set; }
        public string kicker { get; set; }
        public string subheadline { get; set; }
        public object des_facet { get; set; }
        public object org_facet { get; set; }
        public object per_facet { get; set; }
        public object geo_facet { get; set; }
        public List<RelatedUrl> related_urls { get; set; }
        public object multimedia { get; set; }
        public string blog_name { get; set; }
    }

    public class ServiceResult
    {
        public string status { get; set; }
        public string copyright { get; set; }
        public int num_results { get; set; }
        public List<Result> results { get; set; }
    }
}
