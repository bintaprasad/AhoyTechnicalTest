using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Ahoy.Hotel.Data.IData;
using Ahoy.Hotel.Data.AhoyHotelDataContext;
using System.Data.Entity;
using Ahoy.Hotel.Entities.ViewModels;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Ahoy.Hotel.Data
{
    public class HotelRepository: IHotelRepository
    {
        public async Task<HotelModel> GetHotelById(long hotelId)
        {
            try
            {
                var hotelModel = new HotelModel();
                using (var db = new AhoyHotelDatabaseContext())
                {
                    
                    var hotelInfo = await db.Hotels.FirstOrDefaultAsync(a => a.HotelId == hotelId);
                    if(hotelInfo!=null)
                    {
                        hotelModel = new HotelModel()
                        {
                            HotelId = hotelInfo.HotelId,
                            HotelName=hotelInfo.HotelName,
                            HotelDescription= hotelInfo.HotelDescription,
                            StreetAddress1 = string.IsNullOrEmpty(hotelInfo.StreetAddress1)?string.Empty: hotelInfo.StreetAddress1,
                            StreetAddress2 = string.IsNullOrEmpty(hotelInfo.StreetAddress2) ? string.Empty : hotelInfo.StreetAddress2,
                            CityName = hotelInfo.City.CityName,
                            StateName = hotelInfo.State.StateName,
                            CountryName= hotelInfo.Country.CountryName,
                            TotalFare =hotelInfo.TotalFare,
                            Rating= hotelInfo.Rating

                        };

                        
                        
                    }
                }

                return hotelModel;
            }
            catch (Exception ex)
            {              
                Trace.TraceError(ex.Message);
                return null;
            }

            
        }

    }
}