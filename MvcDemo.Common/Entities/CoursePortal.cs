using System;
using System.Collections.Generic;

namespace MvcDemo.Common.Entities
{

    public partial class CoursePortal:Entity<int>
    {
    
        public int PortalId { get; set; }

        public int CourseVariantId { get; set; }

       
        public string CreditTypeCode{ get; set; }

        public string CreditTypeName { get; set; }

        public decimal EarnedCredit { get; set; }

        public string Syllabus { get; set; }

        public string SyllabusUrl { get; set; }

        public decimal RegularPx { get; set; }

        public decimal? SalePx { get; set; }

        public decimal SortOrder { get; set; }

        public bool ForumIndicator { get; set; }

        public int ClassroomSize{ get; set; }

        public int? ForumPostsPerTopic { get; set; }

        public DateTime DisplayStartTime { get; set; }

        public DateTime DisplayFinishTime { get; set; }

        public DateTime PurchaseStartTime { get; set; }

        public DateTime PurchaseFinishTime { get; set; }

        public DateTime AccessStartTime { get; set; }

        public DateTime? AccessFinishTime { get; set; }

        public int? AccessDay { get; set; }

        public bool ActiveIndicator { get; set; }

        public DateTime CreatedTime { get; set; }
        public int CreatedId { get; set; }
        public DateTime? ModifiedTime { get; set; }
        public int? ModifiedId { get; set; }

        public int GradeId { get; set; }

        public string DeploymentStatus { get; set; }

        public int? RegistrationMethod { get; set; }

        public string CoursePortalName { get; set; }

        public bool SelfRegistrationEnabledIndicator { get; set; }

      
        public string CourseDisplayName { get; set; }

        public string CourseDisplayImage { get; set; }

   
        public string CourseSubject { get; set; }

     
        public string CourseTopic { get; set; }

        public string CourseDefaultStandard { get; set; }

        public bool? CreditUpgradeIndicator { get; set; }

        public decimal? UpgradePrice { get; set; }

        public string UpgradeOverview { get; set; }

        public bool EnableEvidence { get; set; }

        public string CreditAcceptance { get; set; }

        public int ClusteredId { get; set; }

        public virtual Portal Portal { get; set; }

        public virtual ICollection<Registration> Registrations { get; set; }
    }
}
