
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
    
public partial class Utiliser
{

    public int Id_Materiel { get; set; }

    public int ID_Projet { get; set; }

    public Nullable<int> Quantite_Utiliser { get; set; }

    public Nullable<int> PrixQuantite { get; set; }



    public virtual Materiel Materiel { get; set; }

    public virtual projet projet { get; set; }

}

}
