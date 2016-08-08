using Guan.Web.Domain.Address;
using Guan.Web.Models.Request;
using Guan.Web.Models.Responses;
using Guan.Web.Services;

using System.Net.Http;
using System.Web.Http;

namespace Guan.Web.Controllers.Api
{
    [RoutePrefix("api/addresses")]
    public class AddressApiController : ApiController
    {
   
        [Route, HttpPost]
        public HttpResponseMessage Add(AddressAddRequest model)
        {

            ItemResponse<int> response = new ItemResponse<int>();

            response.Item = AddressService.Insert(model);


            return Request.CreateResponse(response);
        }


        [Route("{id:int}"), HttpPut]
        public HttpResponseMessage Update(AddressUpdateRequest model, int id)
        {

            AddressService.Update(model, id);

            SuccessResponse response = new SuccessResponse();

            return Request.CreateResponse(response);
        }

        [Route, HttpGet]
        public HttpResponseMessage Get()
        {
            ItemsResponse<Address> response = new ItemsResponse<Address>();

            response.Items = AddressService.Get();

            return Request.CreateResponse(response);
        }

        [Route("{id:int}"), HttpGet]
        public HttpResponseMessage GetByID(int id)
        {
            ItemResponse<Address> response = new ItemResponse<Address>();

            response.Item = AddressService.GetById(id);

            return Request.CreateResponse(response);

        }

        [Route("{id:int}"), HttpDelete]
        public HttpResponseMessage DeleteByID(int id)
        {
            AddressService.DeleteById(id);

            SuccessResponse response = new SuccessResponse();

            return Request.CreateResponse(response);

        }

        [Route("SignChecker"), HttpPost]
        public HttpResponseMessage GetAreaRent(AddressAddRequest model)
        {
            ItemsResponse<Address> response = new ItemsResponse<Address>();

            response.Items = AddressService.GetByGeo(model);

            return Request.CreateResponse(response);
        }

    }
}
