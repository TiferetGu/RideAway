using System;
using System.Collections.Generic;
using System.Text;
using RideAway.Entities.Models;
using RideAway.Entities;
using System.Linq;

namespace RideAway.DataLayer
{
    public interface IPassengerDL
    {
        Passenger GetPassenger(int? idNum, string uniqueCard, IdentityType identityType);
        List<Passenger> GetAllPassengersToday();
    }
    public class PassengerDL : IPassengerDL
    {
        private readonly RideAwayContext ctx;

        public PassengerDL(RideAwayContext iCtx)
        {
            ctx = iCtx;
        }
        public Passenger GetPassenger(int? idNum, string uniqueCard, IdentityType identityType)
        {
            return ctx.Passengers.FirstOrDefault(p => identityType == IdentityType.IdNum && p.IdentityNumber == idNum ||
                                                            identityType == IdentityType.RavKavUniqueCard && p.RavKavId == uniqueCard);
        }

        public List<Passenger> GetAllPassengersToday()
        {
            return ctx.Passengers.Where(x => x.ValidationDate.Date == DateTime.Today).ToList();
        }
    }
}
