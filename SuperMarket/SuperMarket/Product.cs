namespace SuperMarket
{
    public abstract class Product : IPay
    {
        public string Description { get; set; }
        public int Id { get; set; }
        public decimal Price { get; set; }
        public float Tax { get; set; }

        public abstract decimal ValueToPay();
        public override string ToString()
        {
            return $"{Id}\t{Description}" +
                   $"\n\tPrice....................: {$"{Price:C2}",15}" +
                   $"\n\tTax......................: {$"{Tax:P2}",15}";
        }
    }
}
