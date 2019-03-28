using MvcDemo.Common.Entities;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace MvcDemo.DataAccess.Mappings
{
    public class PortalMapping : EntityTypeConfiguration<Portal>
    {
        public const string TableName = "u_portal";

        public PortalMapping()
        {
            ToTable(TableName);
            this.Property(x => x.Id).IsRequired().HasColumnName("portal_id").HasDatabaseGeneratedOption(DatabaseGeneratedOption.None); //PK
            this.Property(x => x.PortalName).IsRequired().HasColumnType("varchar").HasColumnName("portal_nm").HasMaxLength(256);
            this.Property(x => x.ClientId).IsOptional().HasColumnName("client_id");
            this.Property(x => x.StateId).IsOptional().HasColumnName("state_id");
            this.Property(x => x.AgencyId).IsOptional().HasColumnName("agency_id");
            this.Property(x => x.SchoolId).IsOptional().HasColumnName("school_id");
            this.Property(x => x.PortalTypeId).IsRequired().HasColumnName("portal_type_id");
            this.Property(x => x.MarketingPartnerIndicator).IsRequired().HasColumnName("marketing_partner_ind");
            this.Property(x => x.CreditGrantorIndicator).IsRequired().HasColumnName("credit_grantor_ind");
            this.Property(x => x.OtherCreditGrantorId).IsOptional().HasColumnName("other_credit_grantor_id");
            this.Property(x => x.DirectBuyerIndicator).IsRequired().HasColumnName("direct_buyer_ind");
            this.Property(x => x.Notes).IsOptional().HasColumnType("text").HasColumnName("notes");
            this.Property(x => x.DisplayStartTime).IsRequired().HasColumnName("display_start_dt");
            this.Property(x => x.DisplayFinishTime).IsRequired().HasColumnName("display_finish_dt");
            this.Property(x => x.PurchaseStartTime).IsRequired().HasColumnName("purchase_start_dt");
            this.Property(x => x.PurchaseFinishTime).IsRequired().HasColumnName("purchase_finish_dt");
            this.Property(x => x.AccessStartTime).IsRequired().HasColumnName("access_start_dt");
            this.Property(x => x.AccessFinishTime).IsOptional().HasColumnName("access_finish_dt");
            this.Property(x => x.AccessDay).IsOptional().HasColumnName("access_day");
            this.Property(x => x.Title).IsOptional().HasColumnType("text").HasColumnName("title");
            this.Property(x => x.Keyword).IsOptional().HasColumnType("text").HasColumnName("keyword");
            this.Property(x => x.Description).IsOptional().HasColumnType("text").HasColumnName("description");
            this.Property(x => x.Introduction).IsOptional().HasColumnType("text").HasColumnName("introduction");
            this.Property(x => x.Promotion).IsOptional().HasColumnType("text").HasColumnName("promotion");
            this.Property(x => x.Data).IsOptional().HasColumnType("text").HasColumnName("data");
            this.Property(x => x.Completion).IsOptional().HasColumnType("text").HasColumnName("completion");
            this.Property(x => x.FlyerUrl).IsOptional().HasColumnType("varchar").HasColumnName("flyer_url").HasMaxLength(256);
            this.Property(x => x.LogoUrl).IsOptional().HasColumnType("varchar").HasColumnName("logo_url").HasMaxLength(256);
            this.Property(x => x.Logo).IsOptional().HasColumnType("varchar").HasColumnName("logo").HasMaxLength(1024);
            this.Property(x => x.ContactEmail).IsOptional().HasColumnType("varchar").HasColumnName("contact_email").HasMaxLength(256);
            this.Property(x => x.ActiveIndicator).IsRequired().HasColumnName("active_ind");
            this.Property(x => x.CreatedTime).IsRequired().HasColumnName("created_dttm");
            this.Property(x => x.CreatedId).IsRequired().HasColumnName("created_id");
            this.Property(x => x.ModifiedTime).IsOptional().HasColumnName("modified_dttm");
            this.Property(x => x.ModifiedId).IsOptional().HasColumnName("modified_id");
            this.Property(x => x.RoleId);   //public Guid? RoleId { get; set; }
            this.Property(x => x.Theme).IsOptional().HasColumnType("varchar").HasColumnName("theme").HasMaxLength(64);
            this.Property(x => x.LoginPageLogo).IsOptional().HasColumnType("varchar").HasColumnName("login_page_logo").HasMaxLength(100);
            this.Property(x => x.LoginPageText).IsOptional().HasColumnType("varchar").HasColumnName("login_page_text").HasMaxLength(250);
            this.Property(x => x.SpecialUse).IsOptional().HasColumnName("special_use");
            this.Property(x => x.SelfRegistrationIndicator).IsRequired().HasColumnName("self_reg_ind");
            this.Property(x => x.SelfRegistrationLimittedByTeacher).IsOptional().HasColumnName("self_reg_limit_by_teacher");
            this.Property(x => x.EClassroomLogo).IsOptional().HasColumnType("varchar").HasColumnName("eClassroom_logo").HasMaxLength(250);
            this.Property(x => x.SelfRegistrationTeacherCourseLimit).IsOptional().HasColumnName("self_reg_teacher_course_limit");
            this.Property(x => x.ChatIndicator).IsRequired().HasColumnName("chat_ind");
            this.Property(x => x.PasswordChangeRequiredIndicator).IsRequired().HasColumnName("pwd_change_rqd_ind");
            this.Property(x => x.ReviewModeIndicator).IsRequired().HasColumnName("review_mode_ind");
            this.Property(x => x.OnlyGradeCompleteIndicator).IsRequired().HasColumnName("only_grade_complete_ind");
            this.Property(x => x.ClusteredId).IsRequired().HasColumnName("clustered_id");

        }

        /* 


            [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
            public virtual ICollection<u_course_portal> u_course_portal { get; set; }
       */
    }
}
