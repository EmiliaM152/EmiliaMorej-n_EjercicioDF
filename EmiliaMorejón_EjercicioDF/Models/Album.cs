//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EmiliaMorejón_EjercicioDF.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Album
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Album()
        {
            this.Cancion = new HashSet<Cancion>();
        }
    
        public int AlbumID { get; set; }
        public string NombreAlbum { get; set; }
        public Nullable<short> AnioLanzamiento { get; set; }
        public Nullable<short> NumCanciones { get; set; }
        public int ArtistaID { get; set; }
    
        public virtual Artista Artista { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Cancion> Cancion { get; set; }
    }
}
