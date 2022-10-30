namespace OnlineStore.API.ViewModels
{
    public class ProductViewModel
    {

        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
      
        public string ImgUrl { get; set; }

        public CategoryViewModel CategoryViewModel { get; set; }
      
        public int CategoryId { get; set; }
    }
}
