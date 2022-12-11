namespace Builder
{
    public class AudiBuilder : CarBuilder
    {
        public AudiBuilder() : base("Audi") { }

        public override void BuildEngine()
        {
            Car.AddPart("'not a V8'");
        }

        public override void BuildFrame()
        {
            Car.AddPart("'3-door with stripes'");
        }
    }
}
