using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JELOUANE_TRAVAUX_Application_By_JELOUANE_Alale
{
    class ClsEmail
    {
        public string email;

        public ClsEmail() { }

        public ClsEmail(string Email)
        {
            this.email = Email;
        }

        public string Email { get => email; set => email = value; }

    }
}
