//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MVC5DemoApp.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Student
    {
        public int StudentId { get; set; }
        public string StudentName { get; set; }
        public int Programmeid { get; set; }
        public System.DateTime BirthDate { get; set; }
        public string Gender { get; set; }
        public string city { get; set; }
        public string PhoneNumber { get; set; }
        public string Grade { get; set; }
    
        public virtual programme programme { get; set; }
    }
}