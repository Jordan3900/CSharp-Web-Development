namespace CakesWebApp.ViewModels.Cakes
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class OrderInListViewModel
    {
        public int Id { get; set; }

        public DateTime CreatedOn { get; set; }

        public int NumberOfProducts { get; set; }

        public decimal SumOfProducts { get; set; }
    }
}
