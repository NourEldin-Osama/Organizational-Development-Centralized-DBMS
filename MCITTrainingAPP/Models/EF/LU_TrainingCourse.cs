//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MCITTrainingAPP.Models.EF
{
    using System;
    using System.Collections.Generic;
    
    public partial class LU_TrainingCourse
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public LU_TrainingCourse()
        {
            this.TBL_Candidates_Courses = new HashSet<TBL_Candidates_Courses>();
        }
    
        public int TrainingCourseID { get; set; }
        public string TrainingCourseName { get; set; }
        public int TrainingProgramID { get; set; }
        public Nullable<decimal> TrainingCourseCost { get; set; }
    
        public virtual LU_TrainingProgram LU_TrainingProgram { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TBL_Candidates_Courses> TBL_Candidates_Courses { get; set; }
    }
}
