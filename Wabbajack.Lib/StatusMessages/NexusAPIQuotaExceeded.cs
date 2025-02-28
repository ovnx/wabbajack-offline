﻿using Wabbajack.Common.StatusFeed;

namespace Wabbajack.Lib
{
    public class NexusAPIQuotaExceeded : AErrorMessage
    {
        public override string ShortDescription => $"You have exceeded your Nexus API limit for the day";

        public override string ExtendedDescription =>
            "You have exceeded your Nexus API limit for the day, please try again after midnight GMT";
    }
}
