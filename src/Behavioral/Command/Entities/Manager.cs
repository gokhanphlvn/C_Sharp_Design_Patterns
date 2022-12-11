namespace Command.Entities
{
    public class Manager : Employee
    {
        public List<Employee> Employees { get; set; } = new List<Employee>();
        public Manager(int id, string name) : base(id, name)
        {
        }
    }
}
