//------------------------------------------------------------------------------
// <auto-generated>
//    這個程式碼是由範本產生。
//
//    對這個檔案進行手動變更可能導致您的應用程式產生未預期的行為。
//    如果重新產生程式碼，將會覆寫對這個檔案的手動變更。
// </auto-generated>
//------------------------------------------------------------------------------

namespace DBPlayground.EF_Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class exam_master
    {
        public string ExamID { get; set; }
        public Nullable<System.DateTime> StartDateTime { get; set; }
        public Nullable<System.DateTime> EndDateTime { get; set; }
        public string CategoryID { get; set; }
        public string StudentID { get; set; }
        public Nullable<int> CorrectNumber { get; set; }
        public Nullable<int> WrongNumber { get; set; }
        public Nullable<decimal> Rate { get; set; }
    }
}
