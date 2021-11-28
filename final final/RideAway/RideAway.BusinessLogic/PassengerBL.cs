using System;
using System.Collections.Generic;
using System.Text;
using RideAway.Entities;
using RideAway.Entities.Models;
using RideAway.DataLayer;

namespace RideAway.BusinessLayer
{
    public interface IPassengerBL
    {
        int AddOrGetPassengerByIDNum(int idNum);
        int AddOrGetPassengerByUniqueCard(string uniqueCard);
        List<ReasonOfDelay> GetAllReasons();
    }
    public class PassengerBL : IPassengerBL
    {
        private readonly IPassengerDL passengerDL;
        private readonly IReasonOfDelayDl reasonOfDelayDl;
        public PassengerBL(IPassengerDL iPassengerDl, IReasonOfDelayDl iResonOfDelayDl)
        {
            passengerDL = iPassengerDl;
            reasonOfDelayDl = iResonOfDelayDl;
        }
        public int AddOrGetPassengerByIDNum(int idNum)
        {
            var pass = passengerDL.GetPassenger(idNum, string.Empty, IdentityType.IdNum);

            return CheckWaitingTime(pass);
        }
        public int AddOrGetPassengerByUniqueCard(string uniqueCard)
        {
            var pass = passengerDL.GetPassenger(null, uniqueCard, IdentityType.RavKavUniqueCard);

            return CheckWaitingTime(pass);
        }

        public List<ReasonOfDelay> GetAllReasons()
        {
            return reasonOfDelayDl.GetAll();
        }

        private int CheckWaitingTime(Passenger passenger)
        {
            if (passenger != null)
            {
                DateTime now = DateTime.Now;
                var waitingTime = now - passenger.ValidationDate;

                if (waitingTime.TotalMinutes > 60)
                    return (int)PassengerStatus.NewTravel;
                if (waitingTime.TotalMinutes >= 5)
                    return (int)PassengerStatus.MoreThan5Mins;
                return (int)PassengerStatus.LessThen5Mins;
            }
            return (int)PassengerStatus.NewTravel;
        }
    }
}
