using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Royex.Domain.Entity;

namespace Royex.Persistance.Context.Configuration
{
    public class OfficeExecutiveConfiguration : IEntityTypeConfiguration<OfficeExecutive>
    {
        public void Configure(EntityTypeBuilder<OfficeExecutive> builder)
        {
            builder.HasKey(x => x.Id);

            builder.HasOne(x => x.GeneralManager)
                .WithMany(x => x.OfficeExecutives)
                .HasForeignKey(x => x.GeneralManagerId);

            builder.HasData(new OfficeExecutive()
            {
                Id = 1,
                Name = "Sohel",
                Position = Domain.Entity.Shared.Position.OfficeExecutive,
                Salary = 100,
                JoiningDate = new DateTime(2016, 1, 1),
                GeneralManagerId = 2
            },
            new OfficeExecutive()
            {
                Id = 2,
                Name = "Kawser",
                Position = Domain.Entity.Shared.Position.OfficeExecutive,
                Salary = 200,
                JoiningDate = new DateTime(2023, 5, 20),
                GeneralManagerId = 3
            },
            new OfficeExecutive()
            {
                Id = 3,
                Name = "Azad",
                Position = Domain.Entity.Shared.Position.OfficeExecutive,
                Salary = 200,
                JoiningDate = new DateTime(2020, 8, 9),
                GeneralManagerId = 1
            });
        }
    }
}
