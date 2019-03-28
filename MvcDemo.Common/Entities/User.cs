using System;
using System.Collections.Generic;

namespace MvcDemo.Common.Entities
{


    public partial class User:Entity<int>
    {
        public Guid UserId { get; set; }
        public int? ClientId { get; set; }
        public string CompanyName { get; set; }
        public string Title { get; set; }
        public string Department { get; set; }
        public string FirstName { get; set; }     
        public string LastName { get; set; }
        public string Phone1 { get; set; }
        public string Phone2 { get; set; }
        public string Fax { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public int? CountyId { get; set; }
        public string State { get; set; }
        public string PostalCode { get; set; }
        public string SecondaryAddress1 { get; set; }
        public string SecondaryAddress2 { get; set; }
        public string SecondaryCity { get; set; }
        public string SecondaryState { get; set; }
        public string SecondaryPostalCode { get; set; }
        public bool SpeakerIndicator { get; set; }
        public bool MarketingPartnerIndicator { get; set; }
        public bool CreditGrantorIndicator { get; set; }
        public bool DirectBuyerIndicator { get; set; }
        public bool ActiveIndicator { get; set; }
        public DateTime CreatedTime { get; set; }
        public int CreatedId { get; set; }
        public DateTime? ModifiedTime { get; set; }
        public int? ModifiedId { get; set; }
        public bool NotificationEmailIndicator{ get; set; }
        public int? SubjectId { get; set; }
        public int? GradeLevelId { get; set; }
        public int? PositionId { get; set; }
        public bool TemporaryPasswordChanged { get; set; }
        public DateTime? UserAgreementAcceptTime { get; set; }
        public string DistrictEmployeeId { get; set; }
        public string StateEmployeeId { get; set; }
        public string GroupName { get; set; }
        public bool ReviewModeIndicator { get; set; }
        public bool ChatIndicator { get; set; }
        public string Ssn { get; set; }
        public DateTime? Dob { get; set; }
        public string AvatarUrl { get; set; }
        public string ThumbnailUrl { get; set; }

        public int ClusteredId { get; set; }

        public virtual ICollection<Registration> Registrations { get; set; }
    }
}
