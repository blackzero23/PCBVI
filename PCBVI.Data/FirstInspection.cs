//------------------------------------------------------------------------------
// <auto-generated>
//     이 코드는 템플릿에서 생성되었습니다.
//
//     이 파일을 수동으로 변경하면 응용 프로그램에서 예기치 않은 동작이 발생할 수 있습니다.
//     이 파일을 수동으로 변경하면 코드가 다시 생성될 때 변경 내용을 덮어씁니다.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PCBVI.Data
{
    using System;
    using System.Collections.Generic;
    
    public partial class FirstInspection
    {
        public int FirstInspectionId { get; set; }
        public string OCompanyName { get; set; }
        public int ItemId { get; set; }
        public System.DateTime EnterDate { get; set; }
        public Nullable<System.DateTime> CheckDate { get; set; }
        public int EnterQuantity { get; set; }
        public Nullable<int> CheckQuantiy { get; set; }
        public Nullable<int> PassQuantity { get; set; }
        public Nullable<int> ErrorQuantity { get; set; }
        public int EmployeeId { get; set; }
        public int WorkPlaceId { get; set; }
    
        public virtual Employee Employee { get; set; }
        public virtual Item Item { get; set; }
        public virtual WorkPlace WorkPlace { get; set; }
    }
}
