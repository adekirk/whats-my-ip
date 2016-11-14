using System.Net;
using System.Net.Http;
using System.Text;
using System.Web;
using System.Web.Http;

namespace WhatsMyIp.Controllers
{
    public class IpController : ApiController
    {
        [Route("")]
        public HttpResponseMessage Get([FromUri] string format = "")
        {
            var ip = GetClientIp();
            StringContent content = null;

            switch (format?.ToLowerInvariant())
            {
                default:
                    content = new StringContent($"{ip}", Encoding.ASCII, "text/plain");
                    break;

                case "json":
                    content = new StringContent($"{{\"ip\":\"{ip}\"}}", Encoding.ASCII, "application/json");
                    break;
            }


            return new HttpResponseMessage(HttpStatusCode.OK)
            {
                Content = content
            };
        }

        private string GetClientIp()
        {
            return HttpContext.Current?.Request.UserHostAddress;
        }
    }
}