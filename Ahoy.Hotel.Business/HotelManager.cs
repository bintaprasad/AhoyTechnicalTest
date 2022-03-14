using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using Ahoy.Hotel.Business.IBusiness;
using Ahoy.Hotel.Data;
using Ahoy.Hotel.Entities;
using Ahoy.Hotel.Entities.ViewModels;
using Ahoy.Hotel.Data.IData;

namespace Ahoy.Hotel.Business
{
    public class HotelManager: IHotelManager
    {
        private readonly IHotelRepository _hotelRepository;
        public HotelManager(IHotelRepository hotelRepository)
        {
            _hotelRepository = hotelRepository;
        }
        public Task<HotelModel> GetHotelById(long hotelId)
        {
            return _hotelRepository.GetHotelById(hotelId);
        }
    }
}