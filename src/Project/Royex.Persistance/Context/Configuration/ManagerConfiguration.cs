using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Royex.Domain.Entity;

namespace Royex.Persistance.Context.Configuration
{
    public class ManagerConfiguration : IEntityTypeConfiguration<Manager>
    {
        public void Configure(EntityTypeBuilder<Manager> builder)
        {
            builder.HasKey(x => x.Id);

            builder.HasData(new Manager()
            {
                Id = 1,
                Name = "Sojib",
                Position = Domain.Entity.Shared.Position.Manager,
                Salary = 500,
                JoiningDate = new DateTime(1999, 10, 15)
            });
        }
    }
}
