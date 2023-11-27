using Royex.Domain.Entity.Shared;

namespace Royex.Application.Dto
{
    public record EmployeeDto(int Id, string Name, Position Position, int Salary, DateTime JoiningDate)
    {
        
    }
}
