using HMSData.Drug.Enum;


namespace HMSData.Drug
{
    public class Drugs
    {
        public string DrugID { get; }

        public static int s_DrugID = 12345;
        public string Name { get; private set; } = string.Empty;
        public string GenericName { get; set; }
        public string ExpiryDate { get; set; } 
        public DrugForm Form { get; set; }
        public decimal Quantity
        {
            get
            {
                return _drugStock.Sum(m => m.Quantity);
            }
            set { }
        }
        public decimal Price { get; set; }
        public DateOnly DateAdded { get; private set; }
        public TimeOnly TimeAdded { get; private set; }
        public decimal ReorderLevel { get; private set; }
        public DrugStatus DrugStatus { get; set; }
        public string Manufacturer { get; set; }
        public string SupplierName { get; private set; }
        public string SupplierContactInfo { get; set; }

        public IReadOnlyCollection<StockMgt> AllDrugs => _drugStock;

        private readonly HashSet<StockMgt> _drugStock = [];

        public Drugs(string name, string genericName, string expiryDate, DrugForm drugForm,
            decimal quantity, decimal reorderLevel,
            decimal price, string manufacturer, string supplierName,
            string supplierContactInfo
            )
        {
            DrugID = s_DrugID.ToString();
            s_DrugID++;
            Name = name;
            GenericName = genericName;
            ExpiryDate = expiryDate;
            Form = drugForm;
            Price = price;
            ReorderLevel = reorderLevel;
            Manufacturer = manufacturer;
            SupplierName = supplierName;
            SupplierContactInfo = supplierContactInfo;
            DateAdded = new DateOnly(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);
            TimeAdded = new TimeOnly(DateTime.Now.Hour, DateTime.Now.Minute, DateTime.Now.Second);

            if (quantity == 0)
            {
                throw new ArgumentException("Kindly Input a valid Quantity");
            }

            if (quantity < ReorderLevel)
            {
                throw new ArgumentException("Quanity cannot be less than reorder level");
            }

            if (quantity > 0 && quantity > ReorderLevel)
            {
                DrugStatus = DrugStatus.InStock;
                AddDrugs(quantity);
            }

            if (quantity == 0)
            {
                DrugStatus = DrugStatus.OutOfStock;
            }

            if (quantity <= ReorderLevel)
            {
                DrugStatus = DrugStatus.AlmostOutOfStock;
            }

            if (price < 1)
            {
                throw new ArgumentException("Invalid Price");
            }

        }

        public string AddDrugs(decimal amount)
        {
            if (amount <= 0)
            {
                return "Invalid Amount of Drugs";
            }
            var updateStock = new StockMgt(amount, DrugStatus, DrugID);
            _drugStock.Add(updateStock);
            return "";
        }

        public string RemoveDrugs(decimal amount)
        {
            if (amount <= 0)
            {
                return "Invalid Amount of Drugs";
            }

            var removeStock = new StockMgt(-amount, DrugStatus, DrugID);
            _drugStock.Add(removeStock);
            return "";
        }
    }
}
