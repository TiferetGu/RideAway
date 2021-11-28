using System;
using System.Collections.Generic;
using System.Text;
using RideAway.Models;

namespace RideAwayBl
{
    public interface IControlManagerBL
    {
        List<Passenger> GetAllPassengers();
    }
    public class ControlManagerBL : IControlManagerBL
    {
        public List<Passenger> GetAllPassengers()
        {
            return new List<Passenger>();
        }
    }
}
