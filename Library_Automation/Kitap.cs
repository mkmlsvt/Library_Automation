//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Library_Automation
{
    using System;
    using System.Collections.Generic;
    
    public partial class Kitap
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Kitap()
        {
            this.Kiralama = new HashSet<Kiralama>();
        }
    
        public int Id { get; set; }
        public string Ad { get; set; }
        public string Yazar { get; set; }
        public System.DateTime BasimTarihi { get; set; }
        public int BaskiSayisi { get; set; }
        public int Stok { get; set; }
        public int MusaitStok { get; set; }
        public int TurId { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Kiralama> Kiralama { get; set; }
        public virtual KitapTur KitapTur { get; set; }
    }
}
