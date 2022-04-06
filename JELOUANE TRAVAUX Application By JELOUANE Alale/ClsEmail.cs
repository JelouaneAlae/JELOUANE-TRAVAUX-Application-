using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JELOUANE_TRAVAUX_Application_By_JELOUANE_Alale
{
    class ClsEmail
    {
        static string email;
        static int idEquipment;

        public  ClsEmail() { }

        public static int IdEquipment { get => idEquipment; set => idEquipment = value; }

        public string Email { get => email; set => email = value; }

    }
}
