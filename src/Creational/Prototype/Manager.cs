using Newtonsoft.Json;

namespace Prototype
{
    public class Manager : Person
    {
        public override string Name { get; set; }
        public Manager(string name)
        {
            Name = name;
        }

        public override Person Clone(bool deepClone = false)
        {
            if (deepClone)
            {
                var objectAsJson = JsonConvert.SerializeObject(this);
                return JsonConvert.DeserializeObject<Manager>(objectAsJson);
            }
            else
                return (Person)MemberwiseClone();
        }
    }
}
