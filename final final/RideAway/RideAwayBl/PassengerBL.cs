using System;
using System.Collections.Generic;
using System.Text;
using Entities;
using RideAway.Models;

namespace RideAwayBl
{
    public interface IPassengerBL
    {
        int AddOrGetPassengerByIDNum(int idNum);
        int AddOrGetPassengerByUniqueCard(string uniqueCard);
    }
    public class PassengerBL : IPassengerBL
    {
        private readonly IPassengerDL passengerDL;
        public PassengerBL(IPassengerDL iPassengerDl)
        {
            passengerDL = iPassengerDl;
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
