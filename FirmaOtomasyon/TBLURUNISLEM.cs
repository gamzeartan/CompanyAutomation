//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FirmaOtomasyon
{
    using System;
    using System.Collections.Generic;
    
    public partial class TBLURUNISLEM
    {
        public int ISLEMID { get; set; }
        public Nullable<int> FIRMA { get; set; }
        public Nullable<short> PERSONEL { get; set; }
        public Nullable<System.DateTime> GELISTARIH { get; set; }
        public Nullable<System.DateTime> CIKISTARIH { get; set; }
        public Nullable<int> ADET { get; set; }
        public string ACIKLAMA { get; set; }
        public string SERINO { get; set; }
    
        public virtual TBLFIRMA TBLFIRMA { get; set; }
        public virtual TBLPERSONEL TBLPERSONEL { get; set; }
    }
}
