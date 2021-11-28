using System;
using System.Collections.Generic;
using System.Text;
using RideAway.Entities.Models;
using RideAway.DataLayer;

namespace RideAway.BusinessLayer
{
    public interface IControlManagerBL
    {
        List<Passenger> GetAllPassengers();
    }
    public class ControlManagerBL : IControlManagerBL
    {
        private readonly IPassengerDL passengerDl;

        public ControlManagerBL(IPassengerDL iPassengerDl)
        {
            passengerDl = iPassengerDl;
        }
        /// </summary>
        /// <returns></returns>
        public List<Passenger> GetAllPassengers()
        {
            return passengerDl.GetAllPassengersToday();
        }
    }
}
