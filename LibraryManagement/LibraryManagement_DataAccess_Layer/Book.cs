//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LibraryManagement_DataAccess_Layer
{
    using System;
    using System.Collections.Generic;
    
    public partial class Book
    {
        public int Book_Number { get; set; }
        public string Book_Name { get; set; }
        public string Author { get; set; }
        public string Publication { get; set; }
        public int Category_ID { get; set; }
        public int Quantity { get; set; }
    }
}
