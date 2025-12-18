namespace Csharp_Term2_Fall_1404.Entities
{
    public class Product
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public double Price { get; set; }
        public double DiscountPrice { get; set; }

        public void GetProductInfo()
        {
            Console.WriteLine(Name);
            Console.WriteLine(Type);
            Console.WriteLine(Price);
            Console.WriteLine(DiscountPrice);
        }
    }
}
