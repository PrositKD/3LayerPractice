using BLL.DTOs;
using BLL.Services;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Api3layer1.Controllers
{
    public class UserController : ApiController
    {
        [HttpGet]
        [Route("api/name/{id}")]
        public HttpResponseMessage GetNames(int id)
        {
            try
            {
                var data = UserService.GetName(id);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch
            {
                return Request.CreateResponse(HttpStatusCode.NotFound);
            }
        }

        [HttpGet]
        [Route("api/news")]
        public HttpResponseMessage GetNews()
        {
            try
            {
                // Assuming you have a method called GetNews in your service
                var data = UserService.GetNews();
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch
            {
                return Request.CreateResponse(HttpStatusCode.NotFound);
            }
        }

        [HttpPost]
        [Route("api/news/create")]
        public HttpResponseMessage CreateNews([FromBody] newsDto newsDto)
        {
            try
            {
                // Access properties from the DTO (newsDto) and perform actions accordingly
                var data = UserService.CreateNews(newsDto);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch
            {
                return Request.CreateResponse(HttpStatusCode.NotFound);
            }

        }
    }
}
