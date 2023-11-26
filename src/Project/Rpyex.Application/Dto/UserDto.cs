using Royex.Domain.Entity.Shared;

namespace Royex.Application.Dto
{
    public record UserDto(int Id, string Name, Position Position, int Salary, DateTime JoiningDate);
}
