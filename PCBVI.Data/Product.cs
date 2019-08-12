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
    
    public partial class Product
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Product()
        {
            this.FirstInspection = new HashSet<FirstInspection>();
            this.LastInspection = new HashSet<LastInspection>();
            this.Lot = new HashSet<Lot>();
            this.ProductionHistory = new HashSet<ProductionHistory>();
            this.TotalMonitoring = new HashSet<TotalMonitoring>();
        }
    
        public int ProductId { get; set; }
        public string ProductCode { get; set; }
        public int BaecodeId { get; set; }
        public string Name { get; set; }
        public int ProductSubjectId { get; set; }
        public int WorkPlaceId { get; set; }
        public int Quantity { get; set; }
        public string DetailContents { get; set; }
    
        public virtual Barcode Barcode { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FirstInspection> FirstInspection { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LastInspection> LastInspection { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Lot> Lot { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProductionHistory> ProductionHistory { get; set; }
        public virtual ProductSubJect ProductSubJect { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TotalMonitoring> TotalMonitoring { get; set; }
    }
}
