using Adapter.Class_Adapter_Implementation.Models;

namespace Adapter.Class_Adapter_Implementation
{
    public class ExternalSystem
    {
        public CityFromExternalSystem GetCity()
        {
            return new CityFromExternalSystem("Ankara Class", "'t Stand'", 500000);
        }
    }
}
