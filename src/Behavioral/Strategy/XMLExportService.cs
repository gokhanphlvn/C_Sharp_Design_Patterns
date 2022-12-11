namespace Strategy
{
    /// <summary>
    /// ConcreteStrategy
    /// </summary>
    public class XMLExportService : IExportService
    {
        public void Export(Order order)
        {
            Console.WriteLine($"Exporting {order.Name} to XML");
        }
    }
}
