using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using Ahoy.Hotel.Business.IBusiness;

namespace Ahoy.Hotel.API.Controllers
{
    public class HotelController : ApiController
    {
        private readonly IHotelManager _hotelManager;
        
        public HotelController(IHotelManager hotelManager)
        {
            _hotelManager = hotelManager;
        }
        /// <summary>
        /// API for viewing details and info about a specific hotel
        /// </summary>
        /// <param name="hotelId">The identifier.</param>
        /// <returns></returns>
        [HttpGet]
        [Route("~/api/Hotel/GetHotelById/{hotelId}")]
        public async Task<IHttpActionResult> GetHotelById(long hotelId)
        {
            try
            {
                var hotelModel = await _hotelManager.GetHotelById(hotelId);
                if(hotelModel==null)
                {
                    return NotFound();
                }
                return Ok(hotelModel);
            }
            catch (Exception ex)
            {
                Trace.TraceError(ex.Message);
                return InternalServerError(ex);
            }
        }
    }
}