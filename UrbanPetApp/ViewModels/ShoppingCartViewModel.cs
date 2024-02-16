using System.Collections.Generic;
using UrbanPetApp.Models;

namespace UrbanPetApp.ViewModels
{
    public class ShoppingCartViewModel
    {
        public List<Cart> CartItems { get; set; }
        public decimal CartTotal { get; set; }
    }
}