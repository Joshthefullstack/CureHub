using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HMSData.Auth
{
    abstract public class Login
    {
        protected Login() { }

        public bool IsLoggedIn { get; protected set; }

        // I didn't make the name and password constant, because in a real life scneario, a doctor must be able to log in
        // with his own user name and password, and not a general username and password, so the correct username
        // and password, would be passed to the backend from the frontend.

        public bool IsUserLoggedIn(string name, string password, string correctName, string correctPwd)
        {
            if (string.IsNullOrEmpty(name))
            {
                throw new ArgumentNullException("Name cannot be empty");
            }
            if (string.IsNullOrEmpty(password))
            {
                throw new ArgumentNullException("Password cannot be empty");
            }

            if (name != correctName && password != correctPwd)
            {
                throw new ArgumentNullException("Admin Login credentials are incorrect. Input correct credentials.");
            }

            IsLoggedIn = true;
            return IsLoggedIn;
        }

    }
}
