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
    
    public partial class casemap
    {
        public int id { get; set; }
        public int id_map { get; set; }
        public bool mur { get; set; }
        public int x { get; set; }
        public int y { get; set; }
        public bool depart { get; set; }
        public bool fin { get; set; }
        public bool boue { get; set; }
        public bool piege { get; set; }
    
        public virtual map map { get; set; }
    }
}
