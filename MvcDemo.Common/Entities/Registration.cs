using MvcDemo.Common.Entities;
using System;

namespace MvcDemo.Common.Entities
{


    public partial class Registration : Entity<int>
    {

        public int? OrderDetailId { get; set; }

        public int UserId { get; set; }

        public int CoursePortalId { get; set; }

        public DateTime RegistrationTime { get; set; }
             
        public string RegistrationTypeCode { get; set; }

        public DateTime? DropOutTime { get; set; }

        public DateTime AccessStartDate { get; set; }

        public DateTime AccessFinishDate { get; set; }

        public bool ActiveIndicator { get; set; }

        public DateTime CreatedTime { get; set; }

        public int CreatedId { get; set; }

        public DateTime? ModifiedTime { get; set; }

        public int? ModifiedId { get; set; }

        public DateTime? CompleteTime { get; set; }

        public decimal? FinalGrade { get; set; }

        public int? CoursePortalSelfRegistrationId { get; set; }

        public bool? CreditUpgradeIndicator { get; set; }

        public bool WithdrawnIndicator { get; set; }

        public int? GradeId { get; set; }

        public int EnrollmentStatusId { get; set; }

        public DateTime? LastActivityDate { get; set; }

        public int ClusteredId { get; set; }

        public virtual CoursePortal CoursePortal { get; set; }

        public virtual User User { get; set; }
    }
}
