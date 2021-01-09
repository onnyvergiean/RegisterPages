using System;
using System.Collections.Generic;
using System.Text;

namespace RegisterPages.Model
{
    class RegisterUser
    {
        public event EventHandler registerUserEvent;
        public void RegisterAUser()
        {
            Console.WriteLine("User registered");
            if (registerUserEvent != null)
            {
                registerUserEvent(this, EventArgs.Empty);
            }
        }
    }
}
