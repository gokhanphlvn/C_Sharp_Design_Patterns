using Adapter.Object_Adapter_Implementation.Models;

namespace Adapter.Object_Adapter_Implementation
{
    public class ExternalSystem
    {
        public CityFromExternalSystem GetCity()
        {
            return new CityFromExternalSystem("Ankara", "'t Stand'", 500000);
        }
    }
}
