using Ahoy.Hotel.Entities.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ahoy.Hotel.Data.IData
{
    public interface IHotelRepository
    {
        Task<HotelModel> GetHotelById(long hotelId);
    }
}
