﻿using Royex.Domain.Entity;
using Royex.Domain.Repository;

namespace Royex.Domain.RepositoryInterface
{
    public interface IEmployeeRepository : IRepository<Employee>
    {
        Task<bool> IsLeapYear();
        Task<bool> IsStayedFourYears(DateTime joiningDate);
        Task<bool> IsEmployeeJoinedBeforeManager(DateTime magerJoingDate, DateTime employeeJoiningDate);
    }
}