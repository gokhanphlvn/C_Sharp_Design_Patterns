using Adapter.Class_Adapter_Implementation.Models;

namespace Adapter.Class_Adapter_Implementation
{
    public class CityAdapter : ExternalSystem, ICityAdapter
    {
        public City GetCity()
        {
            var cityFromExternalSystem = base.GetCity();

            return new City($"{cityFromExternalSystem.Name} - {cityFromExternalSystem.Name}", cityFromExternalSystem.Inhabitants);
        }
    }
}
