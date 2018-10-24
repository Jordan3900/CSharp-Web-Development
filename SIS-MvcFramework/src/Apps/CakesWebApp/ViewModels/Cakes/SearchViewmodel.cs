using System.Collections.Generic;

namespace CakesWebApp.ViewModels.Cakes
{
    public class SearchViewmodel
    {
        public List<ByIdViewModel> Cakes { get; set; }

        public string SearchText { get; set; }
    }
}