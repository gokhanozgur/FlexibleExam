using FlexibleExam.Core.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlexibleExam.Model.Option
{
    public class LocationRoom:CoreEntity
    {

        public Guid LocationID { get; set; }

        public string RoomNumber { get; set; }

        public string Floor { get; set; }

        public short Capacity { get; set; }

        public string NetworkIP { get; set; }

        public virtual Location Location { get; set; }

        public virtual List<ExamSession> ExamSessions { get; set; }

    }
}
