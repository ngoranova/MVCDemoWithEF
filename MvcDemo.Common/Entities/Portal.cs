using System;
using System.Collections.Generic;

namespace MvcDemo.Common.Entities
{


    public partial class Portal : Entity<int>
    {
      
        public string PortalName { get; set; }

        public int? ClientId { get; set; }

        public int? StateId { get; set; }

        public int? AgencyId { get; set; }

        public int? SchoolId { get; set; }

        public int PortalTypeId { get; set; }

        public bool MarketingPartnerIndicator { get; set; }

        public bool CreditGrantorIndicator { get; set; }

        public int? OtherCreditGrantorId { get; set; }

        public bool DirectBuyerIndicator{ get; set; }

        public string Notes { get; set; }

        public DateTime DisplayStartTime { get; set; }

        public DateTime DisplayFinishTime { get; set; }

        public DateTime PurchaseStartTime { get; set; }

        public DateTime PurchaseFinishTime { get; set; }

        public DateTime AccessStartTime { get; set; }

        public DateTime? AccessFinishTime { get; set; }

        public int? AccessDay { get; set; }

        public string Title { get; set; }

       
        public string Keyword { get; set; }

       
        public string Description { get; set; }

    
        public string Introduction { get; set; }

        public string Promotion { get; set; }

        public string Data { get; set; }

        public string Completion { get; set; }

        public string FlyerUrl { get; set; }

        public string LogoUrl { get; set; }

        public string Logo { get; set; }

         public string ContactEmail { get; set; }

        public bool ActiveIndicator { get; set; }

        public DateTime CreatedTime { get; set; }
        public int CreatedId { get; set; }
        public DateTime? ModifiedTime { get; set; }
        public int? ModifiedId { get; set; }

        public Guid? RoleId { get; set; }

        public string Theme { get; set; }

        public string LoginPageLogo { get; set; }

        public string LoginPageText { get; set; }

        public bool? SpecialUse { get; set; }

        public bool SelfRegistrationIndicator { get; set; }

        public bool? SelfRegistrationLimittedByTeacher { get; set; }

        public string EClassroomLogo { get; set; }

        public int? SelfRegistrationTeacherCourseLimit { get; set; }

        public bool ChatIndicator { get; set; }

        public bool PasswordChangeRequiredIndicator { get; set; }

        public bool ReviewModeIndicator { get; set; }

        public bool? OnlyGradeCompleteIndicator { get; set; }

        public int ClusteredId { get; set; }

        public virtual ICollection<CoursePortal> CoursePortals { get; set; }
    }
}
