namespace CakesWebApp.ViewModels.Orders
{
    using CakesWebApp.ViewModels.Cakes;
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class GetByIdViewModel
    {
        public int Id { get; set; }

        public bool IsShoppingCart { get; set; }

        public IEnumerable<CakeViewModel> Products { get; set; }
    }
}
