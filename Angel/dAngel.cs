//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Angel
{
    using System;
    using System.Collections.Generic;
    
    public partial class dAngel
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public dAngel()
        {
            this.dAngelPracticeDay = new HashSet<dAngelPracticeDay>();
            this.dAngelCharacter = new HashSet<dAngelCharacter>();
        }
    
        public System.Guid IDdAngel { get; set; }
        public string Name { get; set; }
        public int IDsSex { get; set; }
        public Nullable<int> IDsLoyaltyToLaw { get; set; }
    
        public virtual sLoyaltyToLaw sLoyaltyToLaw { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<dAngelPracticeDay> dAngelPracticeDay { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<dAngelCharacter> dAngelCharacter { get; set; }
    }
}
