using _0020_Enumeração.Entities.Enums;
using _0020_Enumeração.Entities;

Order order = new Order
{
    Id = 1080,
    Moment = DateTime.Now,
    Status = OrderStatus.PedingPayment
};

Console.WriteLine(order);

string txt = OrderStatus.PedingPayment.ToString();

OrderStatus os = Enum.Parse<OrderStatus>("Delivered");

Console.WriteLine(txt);
Console.WriteLine(os);
