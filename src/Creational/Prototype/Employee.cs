using Newtonsoft.Json;
using System.Runtime.Serialization.Formatters.Binary;

namespace Prototype
{
    public class Employee : Person
    {
        public Manager Manager { get; set; }
        public override string Name { get; set; }
        public Employee(string name, Manager manager)
        {
            Manager = manager;
            Name = name;
        }

        public override Person Clone(bool deepClone = false)
        {
            if (deepClone)
            {
                var objectAsJson = JsonConvert.SerializeObject(this);
                return JsonConvert.DeserializeObject<Employee>(objectAsJson);
            }
            else
                return (Person)MemberwiseClone();
        }
    }
}
