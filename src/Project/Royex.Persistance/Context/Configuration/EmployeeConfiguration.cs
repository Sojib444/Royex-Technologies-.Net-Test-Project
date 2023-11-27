using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Royex.Domain.Entity;

namespace Royex.Persistance.Context.Configuration
{
    public class EmployeeConfiguration : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            builder.HasKey(x => x.Id);

            builder.HasData(new Employee()
            {
                Id = 1,
                Name = "Abir",
                Position = Domain.Entity.Shared.Position.Manager,
                Salary = 200,
                JoiningDate = new DateTime(2018, 1, 1),
                IsBonusAdded = true,
            },
            new Employee()
            {
                Id = 2,
                Name = "Saddam",
                Position = Domain.Entity.Shared.Position.GeneralManager,
                Salary = 200,
                JoiningDate = new DateTime(2022, 5, 20),
            },
            new Employee()
            {
                Id = 3,
                Name = "Osman",
                Position = Domain.Entity.Shared.Position.GeneralManager,
                Salary = 200,
                JoiningDate = new DateTime(2010, 8, 20),
            },
            new Employee()
            {
                Id = 4,
                Name = "Sohel",
                Position = Domain.Entity.Shared.Position.OfficeExecutive,
                Salary = 100,
                JoiningDate = new DateTime(2016, 1, 1),
            },
            new Employee()
            {
                Id = 5,
                Name = "Kawser",
                Position = Domain.Entity.Shared.Position.OfficeExecutive,
                Salary = 200,
                JoiningDate = new DateTime(2023, 5, 20),
            },
            new Employee()
            {
                Id = 6,
                Name = "Azad",
                Position = Domain.Entity.Shared.Position.OfficeExecutive,
                Salary = 200,
                JoiningDate = new DateTime(2020, 8, 9),
            });

        }
    }
}
