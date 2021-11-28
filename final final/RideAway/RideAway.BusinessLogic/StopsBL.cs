using System;
using System.Collections.Generic;
using System.Text;
using RideAway.Entities.Models;
using RideAway.DataLayer;

namespace RideAway.BusinessLayer
{
    public interface IStopsBL
    {
        int LoginStop(int stopId);
        List<Route> GetLinesForStation(int stopId);
    }
    public class StopsBL:IStopsBL
    {
        public readonly IRouteDl routeDl;
        public StopsBL( IRouteDl iRouteDl)
        {
            routeDl = iRouteDl;
        }
        public int LoginStop(int stopId)
        {
            return 0;
        }
        public List<Route> GetLinesForStation(int stopId)
        {
            return routeDl.GetLinesForStation(stopId);
        }
    }
}
