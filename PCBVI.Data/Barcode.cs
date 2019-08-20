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
    
    public partial class Barcode
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Barcode()
        {
            this.DefectiveProducts = new HashSet<DefectiveProduct>();
            this.LotBarCodes = new HashSet<LotBarCode>();
            this.MaterialHistories = new HashSet<MaterialHistory>();
            this.MaterialsInRes = new HashSet<MaterialsInRe>();
        }
    
        public int BarcodeId { get; set; }
        public Nullable<int> BarcodeCode { get; set; }
        public string State { get; set; }
        public Nullable<int> ErrorCodeId { get; set; }
        public int? ItemId { get; set; }
    
        public virtual ErrorCode ErrorCode { get; set; }
        public virtual Item Item { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DefectiveProduct> DefectiveProducts { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<LotBarCode> LotBarCodes { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MaterialHistory> MaterialHistories { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MaterialsInRe> MaterialsInRes { get; set; }
    }
}
