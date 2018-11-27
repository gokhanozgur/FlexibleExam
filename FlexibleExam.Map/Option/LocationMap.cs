using FlexibleExam.Core.Map;
using FlexibleExam.Model.Option;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlexibleExam.Map.Option
{
    public class LocationMap:CoreMap<Location>
    {

        public LocationMap()
        {
            // Table property settings

            ToTable("dbo.Locations");
            Property(x => x.LocationName).HasMaxLength(100).IsRequired();
            Property(x => x.LocationTelephone).HasMaxLength(100).IsRequired();
            Property(x => x.LocationAddress).HasMaxLength(100).IsRequired();
            Property(x => x.LocationTotalRoom).IsRequired();

            // Table relations

            // LocationRooms Table Relation

            HasMany(x => x.LocationRooms)
                .WithRequired(x => x.Location)
                .HasForeignKey(x => x.LocationID)
                .WillCascadeOnDelete(false);


        }

    }
}
