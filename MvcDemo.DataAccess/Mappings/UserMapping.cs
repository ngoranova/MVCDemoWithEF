using MvcDemo.Common.Entities;
using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations.Schema;

namespace MvcDemo.DataAccess.Mappings
{
    public class UserMapping : EntityTypeConfiguration<User>
    {
        public const string TableName = "u_user";

        public UserMapping()
        {
            ToTable(TableName);
            this.Property(x => x.Id).IsRequired().HasColumnName("user_id").HasDatabaseGeneratedOption(DatabaseGeneratedOption.None); //PK
            this.Property(x => x.UserId).IsRequired();
            this.Property(x => x.ClientId).IsOptional().HasColumnName ("client_id");
            this.Property(x => x.CompanyName).IsOptional().HasColumnType("varchar").HasColumnName("company_nm").HasMaxLength(256); 
            this.Property(x => x.Title).IsOptional().HasColumnType("varchar").HasColumnName("title").HasMaxLength(128); 
            this.Property(x => x.Department).IsOptional().HasColumnType("varchar").HasColumnName("department").HasMaxLength(128); 
            this.Property(x => x.FirstName).IsOptional().HasColumnType("varchar").HasColumnName("first_nm").HasMaxLength(128); 
            this.Property(x => x.LastName).IsOptional().HasColumnType("varchar").HasColumnName("last_nm").HasMaxLength(128); 
            this.Property(x => x.Phone1).IsOptional().HasColumnType("varchar").HasColumnName("phone1").HasMaxLength(32); 
            this.Property(x => x.Phone2).IsOptional().HasColumnType("varchar").HasColumnName("phone2").HasMaxLength(32); 
            this.Property(x => x.Fax).IsOptional().HasColumnType("varchar").HasColumnName("fax").HasMaxLength(32);
            this.Property(x => x.Address1).IsOptional().HasColumnType("varchar").HasColumnName("address1").HasMaxLength(128);
            this.Property(x => x.Address2).IsOptional().HasColumnType("varchar").HasColumnName("address2").HasMaxLength(128);
            this.Property(x => x.City).IsOptional().HasColumnType("varchar").HasColumnName("city").HasMaxLength(128);
            this.Property(x => x.CountyId).IsOptional().HasColumnName("county_id");
            this.Property(x => x.State).IsOptional().HasColumnType("varchar").HasColumnName("state").HasMaxLength(128);
            this.Property(x => x.PostalCode).IsOptional().HasColumnType("varchar").HasColumnName("postal_cd").HasMaxLength(15);
            this.Property(x => x.SecondaryAddress1).IsOptional().HasColumnType("varchar").HasColumnName("sec_address1").HasMaxLength(128);
            this.Property(x => x.SecondaryAddress2).IsOptional().HasColumnType("varchar").HasColumnName("sec_address2").HasMaxLength(128);
            this.Property(x => x.SecondaryCity).IsOptional().HasColumnType("varchar").HasColumnName("sec_city").HasMaxLength(128);
            this.Property(x => x.SecondaryState).IsOptional().HasColumnType("varchar").HasColumnName("sec_state").HasMaxLength(128);
            this.Property(x => x.SecondaryPostalCode).IsOptional().HasColumnType("varchar").HasColumnName("sec_postal_cd").HasMaxLength(15);
            this.Property(x => x.SpeakerIndicator).IsRequired().HasColumnName("speaker_ind");
            this.Property(x => x.MarketingPartnerIndicator).IsRequired().HasColumnName("marketing_partner_ind");
            this.Property(x => x.CreditGrantorIndicator).IsRequired().HasColumnName("credit_grantor_ind");
            this.Property(x => x.DirectBuyerIndicator).IsRequired().HasColumnName("direct_buyer_ind");
            this.Property(x => x.ActiveIndicator).IsRequired().HasColumnName("active_ind");
            this.Property(x => x.CreatedTime).IsRequired().HasColumnName("created_dttm");
            this.Property(x => x.CreatedId).IsRequired().HasColumnName("created_id");
            this.Property(x => x.ModifiedTime).IsOptional().HasColumnName("modified_dttm");
            this.Property(x => x.ModifiedId).IsOptional().HasColumnName("modified_id");
            this.Property(x => x.NotificationEmailIndicator).IsRequired().HasColumnName("notification_email_ind");
            this.Property(x => x.SubjectId).IsOptional().HasColumnName("subject_id");
            this.Property(x => x.GradeLevelId).IsOptional().HasColumnName("grade_level_id");
            this.Property(x => x.PositionId).IsOptional().HasColumnName("position_id");
            this.Property(x => x.TemporaryPasswordChanged).IsRequired().HasColumnName("temp_pwd_changed");
            this.Property(x => x.UserAgreementAcceptTime).IsOptional().HasColumnName("user_agreement_accept_dttm");
            this.Property(x => x.DistrictEmployeeId).IsOptional().HasColumnType("varchar").HasColumnName("district_employee_id").HasMaxLength(50);
            this.Property(x => x.StateEmployeeId).IsOptional().HasColumnType("varchar").HasColumnName("state_employee_id").HasMaxLength(50);
            this.Property(x => x.GroupName).IsOptional().HasColumnType("varchar").HasColumnName("group_nm").HasMaxLength(64);
            this.Property(x => x.ReviewModeIndicator).IsRequired().HasColumnName("review_mode_ind");
            this.Property(x => x.ChatIndicator).IsRequired().HasColumnName("chat_ind");
            this.Property(x => x.Ssn).IsOptional().HasColumnType("varchar").HasColumnName("soc_sec_nmb").HasMaxLength(12);
            this.Property(x => x.Dob).IsOptional().HasColumnName("date_of_birth");
            this.Property(x => x.AvatarUrl).IsOptional().HasColumnType("varchar").HasColumnName("avatar_url").HasMaxLength(256);
            this.Property(x => x.ThumbnailUrl).IsOptional().HasColumnType("varchar").HasColumnName("thumbnail_url").HasMaxLength(256);
            this.Property(x => x.ClusteredId).IsRequired().HasColumnName("clustered_id");  

        }
    }
}
