//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace JELOUANE_TRAVAUX_Application_By_JELOUANE_Alale
{
    using System;
    using System.Collections.Generic;
    
    public partial class projet
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public projet()
        {
            this.Salles = new HashSet<Salle>();
            this.Utilisers = new HashSet<Utiliser>();
        }
    
        public int ID_Projet { get; set; }
        public Nullable<System.DateTime> Datedebut_Projet { get; set; }
        public Nullable<System.DateTime> DateFin_Projet { get; set; }
        public string Etat_Projet { get; set; }
        public Nullable<int> ID_Client { get; set; }
    
        public virtual Client Client { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Salle> Salles { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Utiliser> Utilisers { get; set; }
    }
}
