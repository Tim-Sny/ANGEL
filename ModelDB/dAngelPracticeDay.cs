//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ModelDB
{
    using System;
    using System.Collections.Generic;
    
    public partial class dAngelPracticeDay
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public dAngelPracticeDay()
        {
            this.dAngelPracticeDayShift = new HashSet<dAngelPracticeDayShift>();
        }
    
        public System.Guid IDdPracticeDay { get; set; }
        public System.Guid IDdAngel { get; set; }
        public int DayNumber { get; set; }
        public int IDsActivity { get; set; }
    
        public virtual dAngel dAngel { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<dAngelPracticeDayShift> dAngelPracticeDayShift { get; set; }
    }
}
