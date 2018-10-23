namespace CakesWebApp.ViewModels.User
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class ProfileViewModel
    {
        public string Username { get; set; }

        public DateTime DateOfRegister { get; set; }

        public int OrdersCount { get; set; }
    }
}
