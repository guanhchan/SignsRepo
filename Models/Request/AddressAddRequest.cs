using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Guan.Web.Models.Request
{
    public class AddressAddRequest
    {
        public string UserId { get; set; }

        public string Line1 { get; set; }

        public string City { get; set; }

        public string State { get; set; }

        public string ZipCode { get; set; }

        public decimal Lat { get; set; }

        public decimal Lng { get; set; }

        public string StreetHourStart { get; set; }

        public string StreetHourEnd { get; set; }

        public int DayOfWeek { get; set; }

        public string TimeLimit { get; set; }

        public int Radius { get; set; }
    }
}