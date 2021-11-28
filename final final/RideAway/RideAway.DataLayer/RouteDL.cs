using System;
using System.Collections.Generic;
using System.Text;
using RideAway.Entities.Models;

namespace RideAway.DataLayer
{
    public interface IRouteDl
    {
        List<Route> GetLinesForStation(int stopId);
    }

    public class RouteDl : IRouteDl
    {
        private readonly RideAwayContext ctx;

        public RouteDl(RideAwayContext context)
        {
            ctx = context;
        }
        public List<Route> GetLinesForStation(int stopId)
        {
            return null;// ctx.
        }
    }
}
