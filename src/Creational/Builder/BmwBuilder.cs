namespace Builder
{
    public class BmwBuilder : CarBuilder
    {
        public BmwBuilder() : base("BMW") { }
        public override void BuildEngine()
        {
            Car.AddPart("'a fancy V8 engine'");
        }

        public override void BuildFrame()
        {
            Car.AddPart("'5-door with metallic finish'");
        }
    }
}
