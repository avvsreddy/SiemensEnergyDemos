namespace ProductCatelogMVCWebApp.Models.Entities
{
    public class Product
    {
        public int ProductID { get; set; }
        public string ProductName { get; set; }

        public int Price { get; set; }

        public bool IsAvailable { get; set; }

        public string Category { get; set; }


    }
}
