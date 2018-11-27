using FlexibleExam.Core.Map;
using FlexibleExam.Model.Option;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlexibleExam.Map.Option
{
    public class LocationRoomMap:CoreMap<LocationRoom>
    {

        public LocationRoomMap()
        {
            // Table property settings

            ToTable("dbo.LocationRooms");
            Property(x => x.RoomNumber).HasMaxLength(10).IsRequired();
            Property(x => x.Floor).HasMaxLength(10).IsRequired();
            Property(x => x.Capacity).IsRequired();
            Property(x => x.NetworkIP).HasMaxLength(15).IsRequired();

            // Table relations

            // Location Table Relation

            HasRequired(x => x.Location)
                .WithMany(x => x.LocationRooms)
                .HasForeignKey(x => x.LocationID)
                .WillCascadeOnDelete(false);
            

        }

    }
}
