using Royex.Domain.Entity.Shared;

namespace Royex.Domain.Entity
{
    public class OfficeExecutive
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Position Position { get; set; }
        public int Salary { get; set; }
        public DateTime JoiningDate { get; set; }
        public int GeneralManagerId { get; set; }
        public GeneralManager GeneralManager { get; set; }
    }
}
