//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace YETIAPI
{
    using System;
    using System.Collections.Generic;
    
    public partial class Person
    {
        public int PersonId { get; set; }
        public string PersonPhone { get; set; }
        public string PersonEmail { get; set; }
        public string Password { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Patronymic { get; set; }
        public System.DateTime Birthdate { get; set; }
        public string PersonResidence { get; set; }
        public byte[] PersonImage { get; set; }
        public int GenderId { get; set; }
        public int RoleId { get; set; }
    
        public virtual Gender Gender { get; set; }
        public virtual Role Role { get; set; }
    }
}
