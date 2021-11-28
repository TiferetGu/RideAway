using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RideAway.Entities.Models;

namespace RideAway.DataLayer
{
    public interface IReasonOfDelayDl
    {
        List<ReasonOfDelay> GetAll();
    }
    public class ReasonOfDelayDL : IReasonOfDelayDl
    {
        private readonly RideAwayContext ctx;
        public ReasonOfDelayDL(RideAwayContext iCtx)
        {
            ctx = iCtx;
        }

        public List<ReasonOfDelay> GetAll()
        {
            return ctx.ReasonOfDelays.ToList();
        }
    }
}
