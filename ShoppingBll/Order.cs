namespace OrderBll
{
    public class Order
    {
        public int ItemQty { get; private set; }
        public decimal ItemPrice { get; private set; }
        public CityCode CityCode { get; private set; }

        public Order(int itemQty, decimal itemPrice, CityCode cityCode)
        {
            ItemQty = itemQty;
            ItemPrice = itemPrice;
            CityCode = cityCode;
        }
    }
}
