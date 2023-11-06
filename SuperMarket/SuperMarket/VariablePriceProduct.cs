namespace SuperMarket
{
    public class VariablePriceProduct : Product
    {
        public string Measurement { get; set; }
        public float Quantity { get; set; }
        public override decimal ValueToPay()
        {
            return (decimal)Quantity * Price;
        }
        public override string ToString()
        {
            return base.ToString()+
                   $"\n\tMeasurement..............: {$"{Measurement}",15}"+
                   $"\n\tQuantity.................: {$"{Quantity:N2}",15}";
        }
    }
}
