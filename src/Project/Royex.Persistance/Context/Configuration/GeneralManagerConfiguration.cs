﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Royex.Domain.Entity;

namespace Royex.Persistance.Context.Configuration
{
    public class GeneralManagerConfiguration : IEntityTypeConfiguration<GeneralManager>
    {
        public void Configure(EntityTypeBuilder<GeneralManager> builder)
        {
            builder.HasKey(x => x.Id);

            builder.HasOne(x => x.Manager)
                .WithMany(x => x.GeneralManagers)
                .HasForeignKey(x => x.ManagerId);

            builder.HasData(new GeneralManager()
            {
                Id = 1,
                Name = "Abir",
                Position = Domain.Entity.Shared.Position.GeneralManager,
                Salary = 200,
                JoiningDate = new DateTime(2018, 1, 1),
                ManagerId = 1
            },
            new GeneralManager()
            {
                Id = 2,
                Name = "Saddam",
                Position = Domain.Entity.Shared.Position.GeneralManager,
                Salary = 200,
                JoiningDate = new DateTime(2022, 5, 20),
                ManagerId = 1
            },
            new GeneralManager()
            {
                Id = 2,
                Name = "Osman",
                Position = Domain.Entity.Shared.Position.GeneralManager,
                Salary = 200,
                JoiningDate = new DateTime(2010, 8, 20),
                ManagerId = 1
            });

        }
    }
}