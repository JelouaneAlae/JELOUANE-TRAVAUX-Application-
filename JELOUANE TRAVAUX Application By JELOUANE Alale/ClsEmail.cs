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
        static int ID_CLIENT;
        static int ID_PROJECT;
        static string Name_client;
        static string Prenom_Client;
        static string Project_name;
        static DateTime Project_Starting_date;
        static int ID_salle;
        static string Nom_salle;
        static string ExpiryreminderBefore;
        static string KeyLang;
        static string theme;
        public static bool savelogininfo;
        static string applan;



        public static string Theme { get => theme; set => theme = value; }
        public static string Applan { get => applan; set => applan = value; }
        public static bool Savelogininfo { set => savelogininfo = false; }


        public ClsEmail() { }

        public static string project_name { get => Project_name; set => Project_name = value; }
        public static int IdEquipment { get => idEquipment; set => idEquipment = value; }

        public static int ID_CLIENt { get => ID_CLIENT; set => ID_CLIENT = value; }
        public static string prenom_Client { get => Prenom_Client; set => Prenom_Client = value; }

        public static string Name_Client { get => Name_client; set => Name_client = value; }
        public static int ID_PROJECt { get => ID_PROJECT; set => ID_PROJECT = value; }

        public static string Email { get => email; set => email = value; }

        public static string nom_salle { get => Nom_salle; set => Nom_salle = value; }
        public static int iD_salle { get => ID_salle; set => ID_salle = value; }

        public static DateTime project_Starting_date { get => Project_Starting_date; set => Project_Starting_date = value; }
        public static string expiryreminderBefore { get => ExpiryreminderBefore; set => ExpiryreminderBefore = value; }

        public static string keyLang { get => KeyLang; set => KeyLang= value; }

    }
}
