namespace CakesWebApp.ViewModels.Cakes
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class ByIdViewModel
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public decimal Price { get; set; }

        public string ImageUrl { get; set; }
    }
}
