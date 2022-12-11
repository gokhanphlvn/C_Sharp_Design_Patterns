// See https://aka.ms/new-console-template for more information
using Observer;

Console.Title = "Observer Pattern";

TicketStockService ticketStockService = new();
TickedResellerService tickedResellerService = new();
OrderService orderService = new();

//Add two observers
orderService.AddObserver(ticketStockService);
orderService.AddObserver(tickedResellerService);

// notfiy
orderService.CompleteTicketSale(1, 2);

Console.WriteLine();
//remove one observer
orderService.RemoveObserver(tickedResellerService);

// notify
orderService.CompleteTicketSale(2, 4);

Console.ReadKey();