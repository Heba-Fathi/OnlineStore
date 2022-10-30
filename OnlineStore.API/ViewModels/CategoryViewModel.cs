using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace OnlineStore.API.ViewModels
{
    public class CategoryViewModel
    {

        [Required]
        [Display(Name = "Name")]
        public string Name { get; set; }
        public IEnumerable<ProductViewModel> ProductViewModels { get; set; }
    }
}
