namespace Builder
{
    public class Garage
    {
        private CarBuilder? _builder;
        public Garage() { }
        public void Construct(CarBuilder carBuilder)
        {
            _builder = carBuilder;
            _builder.BuildEngine();
            _builder.BuildFrame();
        }
        public void Show()
        {
            Console.WriteLine(_builder?.Car.ToString());
        }
    }
}
