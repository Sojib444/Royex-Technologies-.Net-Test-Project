using Royex.Domain.Entity.Shared;

namespace Royex.Domain.Entity
{
    public class GeneralManager
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Position Position { get; set; }
        public int Salary { get; set; }
        public DateTime JoiningDate { get; set; }
        public int ManagerId { get; set; }
        public Manager Manager { get; set; }
        public List<OfficeExecutive> OfficeExecutives { get; set; }
    }
}
