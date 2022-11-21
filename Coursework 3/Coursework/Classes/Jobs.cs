using System;

namespace Coursework
{
    public partial class frmJobs
    {
        public class Jobs
        {
            public int JobID { get; set; }
            public DateTime CurrentJob { get; set; }
            public DateTime NextRequiredJob { get; set; }
            public int ChimneyType { get; set; }

            public int ClientID { get; set; }

            public string ClientName { get; set; }
        }

    }
}
