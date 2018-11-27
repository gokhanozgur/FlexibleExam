using FlexibleExam.Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlexibleExam.Model.Option
{
    public class Location:CoreEntity
    {

        public string LocationName { get; set; }

        public string LocationTelephone { get; set; }

        public string LocationAddress { get; set; }

        public short LocationTotalRoom { get; set; }

        public virtual List<LocationRoom> LocationRooms { get; set; }

    }
}
