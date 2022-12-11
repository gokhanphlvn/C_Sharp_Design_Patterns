using System.Reflection.Metadata.Ecma335;

namespace Strategy
{
    /// <summary>
    /// Context
    /// </summary>
    public class Order
    {
        public string Customer { get; set; }
        public string Name { get; set; }
        public int Amount { get; set; }
        public string? Description { get; set; }
        public IExportService? ExportService { get; set; }
        public Order(string customer, int amount, string name)
        {
            Customer = customer;
            Name = name;
            Amount = amount;
        }
        public Order(string customer, int amount, string name, IExportService? exportService) : this(customer, amount, name)
        {
            ExportService = exportService;
        }
        public void Export()
        {
            ExportService?.Export(this);
        }

        public void Export(IExportService? exportService)
        {
            if (exportService is null)
            {
                throw new NullReferenceException(nameof(exportService));
            }
            exportService?.Export(this);
        }
    }
}