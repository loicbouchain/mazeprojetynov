//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré à partir d'un modèle.
//
//     Des modifications manuelles apportées à ce fichier peuvent conduire à un comportement inattendu de votre application.
//     Les modifications manuelles apportées à ce fichier sont remplacées si le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace mazeprojetynov
{
    using System;
    using System.Collections.Generic;
    
    public partial class test
    {
        public int id { get; set; }
        public int id_map { get; set; }
        public string resultat { get; set; }

        public string nom_createur { get; set; }
        public Nullable<System.DateTime> date { get; set; }


    
        public virtual map map { get; set; }
    }
}
