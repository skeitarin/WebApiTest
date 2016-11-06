using Newtonsoft.Json;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;

namespace WebApiTest.Util
{
    public class JsonUtil
    {
        public HttpResponseMessage ReturnJson(object obj)
        {
            var responce = new HttpResponseMessage();

            // CORS（Cross-Origin Resource Sharing）の設定（クロスドメイン対策）
            responce.Headers.Add("Access-Control-Allow-Origin", "*");
            responce.Headers.Add("Access-Control-Allow-Headers", "X-Requested-With");
            responce.Headers.Add("Access-Control-Allow-Methods", "GET");

            responce.Content = CreateHttpContentJson(obj);

            return responce;
        }

        private static HttpContent CreateHttpContentJson(object obj)
        {
            var jsonText = JsonConvert.SerializeObject(obj);
            var content = new ByteArrayContent(Encoding.UTF8.GetBytes(jsonText));
            content.Headers.ContentType = new MediaTypeHeaderValue("application/json");
            return content;
        } 
    }
}