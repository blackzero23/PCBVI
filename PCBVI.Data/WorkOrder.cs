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
    
    public partial class WorkOrder
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public WorkOrder()
        {
            this.WorkLogs = new HashSet<WorkLog>();
        }
    
        public int? WorkOrderId { get; set; }
        public int? ItemId { get; set; }
        public System.DateTime OrderDate { get; set; }
        public int? RotationGroupId { get; set; }
        public int TargetQuantity { get; set; }
        public int? ProcessId { get; set; }
        public int? WorkPlaceId { get; set; }
        public string Note { get; set; }
        public string WorkerName { get; set; }
        public int? FacilitiesId { get; set; }
    
        public virtual Facility Facility { get; set; }
        public virtual Item Item { get; set; }
        public virtual Process Process { get; set; }
        public virtual RotationGroup RotationGroup { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<WorkLog> WorkLogs { get; set; }
        public virtual WorkPlace WorkPlace { get; set; }
    }
}
