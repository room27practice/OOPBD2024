namespace AutoServiceDiscountManager
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            var customer1 = new Customer("Kuncho", DriverType.Trucks_C);
            var customer2 = new Customer();
            Console.WriteLine(customer1.Name);

            Customer c3 = new Customer();

            //TODO...
        }
    }

    public class Customer
    {
        public Customer()
        {

        }

        private static decimal annualRefundCoef = 15.00m;
        private static int maxLVLVIP = 10;

        public string Name { get; private set; }
        public string Address { get; set; }

        public DateTime BirthDate { get; private set; }

        public DriverType DriverType { get; set; }

        public int VIPlvl { get; private set; }

        public List<Order> Orders { get; set; }

        public Customer(string name, DriverType d)
        {
            Name = name;
            DriverType = d;
        }

        public Customer(string name, string driverType)
        {
            if (name.Length < 2)
            {
                Console.WriteLine("Gledai si rabotata!");
                return;
            }
            Name = name;
            DriverType = Enum.Parse<DriverType>(driverType);
        }

        public Customer(string name, string address, DateTime birthDate, DriverType driverType)
        {
            Name = name;
            Address = address;
            BirthDate = birthDate;
            DriverType = driverType;
        }

        public int ImproveVip()
        {
            if (VIPlvl == maxLVLVIP)
            {
                Console.WriteLine($"Maximal VIP= {maxLVLVIP} reached already");
                return maxLVLVIP;
            }
            VIPlvl++;
            return VIPlvl;
        }

        public decimal GetSpentMoney()
        {
            decimal profit = 0;

            foreach (Order order in Orders)
            {
                profit += order.Price;
            }
            return profit;
        }

        public void RegirsterOrder(Order o)//
        {
          decimal newPrice = o.Price * (1 - (annualRefundCoef * VIPlvl) / (100 * maxLVLVIP));
            o.Price = newPrice;            
            Orders.Add(o);
        }
    }
    public class Order
    {
        private decimal price;

        public Order(string description, DateTime date, decimal price)
        {
            Description = description;

            Price = price;

            if (date.Year < DateTime.UtcNow.Year)
            {
                Console.WriteLine("Invalid Date");
                Date = DateTime.UtcNow;
            }
            else
            {
                Date = date;
            }
        }

        public string Description { get; set; }
        public DateTime Date { get; private set; }
        public decimal Price
        {
            get
            {
                return 1.2m * price;
            }
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("Invalid Price Value!");
                    price = 0;
                }
                else
                {
                    price = value;
                }
            }




        }
    }
    public enum DriverType
    {
        Undefined,
        Motor_A,
        Automobiles_B,
        Trucks_C,
        Bycicle_0,
    }
}