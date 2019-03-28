using MvcDemo.Common.Entities;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace MvcDemo.DataAccess.Mappings
{
    public class CoursePortalMapping : EntityTypeConfiguration<CoursePortal>
    {
        public const string TableName = "u_course_portal";

        public CoursePortalMapping()
        {
            ToTable(TableName);
            this.Property(x => x.Id).IsRequired().HasColumnName("course_portal_id").HasDatabaseGeneratedOption(DatabaseGeneratedOption.None); //PK 
            this.Property(x => x.PortalId).IsRequired().HasColumnName("portal_id");
            this.Property(x => x.CourseVariantId).IsRequired().HasColumnName("course_variant_id");
            this.Property(x => x.CreditTypeCode).IsRequired().HasColumnType("char").HasColumnName("credit_type_cd").HasMaxLength(4);
            this.Property(x => x.CreditTypeName).IsOptional().HasColumnType("varchar").HasColumnName("credit_type_nm").HasMaxLength(128);
            this.Property(x => x.EarnedCredit).HasPrecision(3, 1).IsRequired().HasColumnName("earned_credit");
            this.Property(x => x.Syllabus).IsOptional().HasColumnType("text").HasColumnName("syllabus");
            this.Property(x => x.SyllabusUrl).IsOptional().HasColumnType("varchar").HasColumnName("syllabus_url").HasMaxLength(256);
            this.Property(x => x.RegularPx).HasPrecision(13, 4).IsRequired().HasColumnName("regular_px");
            this.Property(x => x.SalePx).HasPrecision(13, 4).IsOptional().HasColumnName("sale_px");
            this.Property(x => x.SortOrder).HasPrecision(10, 4).IsRequired().HasColumnName("sort_order");
            this.Property(x => x.ForumIndicator).IsRequired().HasColumnName("forum_ind");
            this.Property(x => x.ClassroomSize).IsRequired().HasColumnName("classroom_sz");
            this.Property(x => x.ForumPostsPerTopic).IsOptional().HasColumnName("forum_posts_per_topic");
            this.Property(x => x.DisplayStartTime).IsRequired().HasColumnName("display_start_dt");
            this.Property(x => x.DisplayFinishTime).IsRequired().HasColumnName("display_finish_dt");
            this.Property(x => x.PurchaseStartTime).IsRequired().HasColumnName("purchase_start_dt");
            this.Property(x => x.PurchaseFinishTime).IsRequired().HasColumnName("purchase_finish_dt");
            this.Property(x => x.AccessStartTime).IsRequired().HasColumnName("access_start_dt");
            this.Property(x => x.AccessFinishTime).IsOptional().HasColumnName("access_finish_dt");
            this.Property(x => x.AccessDay).IsOptional().HasColumnName("access_day");
            this.Property(x => x.ActiveIndicator).IsRequired().HasColumnName("active_ind");
            this.Property(x => x.CreatedTime).IsRequired().HasColumnName("created_dttm");
            this.Property(x => x.CreatedId).IsRequired().HasColumnName("created_id");
            this.Property(x => x.ModifiedTime).IsOptional().HasColumnName("modified_dttm");
            this.Property(x => x.ModifiedId).IsOptional().HasColumnName("modified_id");
            this.Property(x => x.GradeId).IsRequired().HasColumnName("grade_id");
            this.Property(x => x.DeploymentStatus).IsOptional().HasColumnType("varchar").HasColumnName("deployment_status").IsMaxLength();
            this.Property(x => x.RegistrationMethod).IsOptional().HasColumnName("reg_method");
            this.Property(x => x.CoursePortalName).IsOptional().HasColumnType("varchar").HasColumnName("course_portal_nm").HasMaxLength(256);
            this.Property(x => x.SelfRegistrationEnabledIndicator).IsRequired().HasColumnName("self_reg_enabled_ind");
            this.Property(x => x.CourseDisplayName).IsOptional().HasColumnType("varchar").HasColumnName("course_display_nm").HasMaxLength(256);
            this.Property(x => x.CourseDisplayImage).IsOptional().HasColumnType("varchar").HasColumnName("course_display_img").IsMaxLength();
            this.Property(x => x.CourseSubject).IsOptional().HasColumnType("varchar").HasColumnName("course_subject").HasMaxLength(256);
            this.Property(x => x.CourseTopic).IsOptional().HasColumnType("varchar").HasColumnName("course_topic").HasMaxLength(256);
            this.Property(x => x.CourseDefaultStandard).IsOptional().HasColumnType("varchar").HasColumnName("course_default_standard").HasMaxLength(256);
            this.Property(x => x.CreditUpgradeIndicator).IsOptional().HasColumnName("credit_upgrade_ind");
            this.Property(x => x.UpgradePrice).HasPrecision(12, 4).IsOptional().HasColumnName("upgrade_price");
            this.Property(x => x.UpgradeOverview).IsOptional().HasColumnType("varchar").HasColumnName("upgrade_overview").IsMaxLength();
            this.Property(x => x.EnableEvidence).IsRequired().HasColumnName("enable_evidence");
            this.Property(x => x.CreditAcceptance).IsOptional().HasColumnType("varchar").HasColumnName("credit_acceptance").IsMaxLength();
            this.Property(x => x.ClusteredId).IsRequired().HasColumnName("clustered_id");

        }


        /*




      

        public int clustered_id { get; set; }

        public virtual u_portal u_portal { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<u_registration> u_registration { get; set; }
  */
    }
}
