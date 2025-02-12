using HMSData.Drug.Enum;


namespace HMSData.Drug
{
    public class StockMgt
    {
        public decimal Quantity { get; private set; }
        public DateOnly DateUpdated { get; private set; }
        public TimeOnly TimeUpdated { get; private set; }
        public DrugStatus DrugStatus { get; set; }
        public string DrugID { get; }

        public StockMgt(decimal quantity, DrugStatus drugStatus, string drugID)
        {
            Quantity = quantity;
            DateUpdated = new DateOnly(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);
            TimeUpdated = new TimeOnly(DateTime.Now.Hour, DateTime.Now.Minute, DateTime.Now.Second);
            DrugStatus = drugStatus;
            DrugID = drugID;
        }
    }
}
