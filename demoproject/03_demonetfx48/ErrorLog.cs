//------------------------------------------------------------------------------
// <auto-generated>
//     このコードはテンプレートから生成されました。
//
//     このファイルを手動で変更すると、アプリケーションで予期しない動作が発生する可能性があります。
//     このファイルに対する手動の変更は、コードが再生成されると上書きされます。
// </auto-generated>
//------------------------------------------------------------------------------

namespace _03_demonetfx48
{
    using System;
    using System.Collections.Generic;
    
    public partial class ErrorLog
    {
        public int ErrorLogID { get; set; }
        public System.DateTime ErrorTime { get; set; }
        public string UserName { get; set; }
        public int ErrorNumber { get; set; }
        public Nullable<int> ErrorSeverity { get; set; }
        public Nullable<int> ErrorState { get; set; }
        public string ErrorProcedure { get; set; }
        public Nullable<int> ErrorLine { get; set; }
        public string ErrorMessage { get; set; }
    }
}
