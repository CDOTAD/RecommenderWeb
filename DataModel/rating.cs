//------------------------------------------------------------------------------
// <auto-generated>
//    此代码是根据模板生成的。
//
//    手动更改此文件可能会导致应用程序中发生异常行为。
//    如果重新生成代码，则将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataModel
{
    using System;
    using System.Collections.Generic;
    
    public partial class rating
    {
        public int userId { get; set; }
        public int movieId { get; set; }
        public float rating1 { get; set; }
        public Nullable<int> timestamp { get; set; }
    
        public virtual movie movie { get; set; }
        public virtual user user { get; set; }
    }
}