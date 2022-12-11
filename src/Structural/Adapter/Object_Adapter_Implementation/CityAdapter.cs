using Adapter.Object_Adapter_Implementation.Models;

namespace Adapter.Object_Adapter_Implementation
{
    public class CityAdapter : ICityAdapter
    {

        public ExternalSystem ExternalSystem { get; private set; } = new();

        public City GetCity()
        {
            var cityFromExternalSystem = ExternalSystem.GetCity();

            return new City($"{cityFromExternalSystem.Name} - {cityFromExternalSystem.Name}", cityFromExternalSystem.Inhabitants);
        }
    }
}
