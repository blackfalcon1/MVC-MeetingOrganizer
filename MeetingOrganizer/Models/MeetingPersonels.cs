//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MeetingOrganizer.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class MeetingPersonels
    {
        public int ID { get; set; }
        public int MeetingID { get; set; }
        public int PersonelID { get; set; }
        public bool IsDeleted { get; set; }
    }
}
