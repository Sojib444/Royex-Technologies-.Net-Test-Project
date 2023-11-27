using Royex.Domain.Entity.Shared;

namespace Royex.Domain.Entity
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Position Position { get; set; }
        public int Salary { get; set; }
        public DateTime JoiningDate { get; set; }
        public bool IsBonusAdded { get; set; } = false;
    }
}
