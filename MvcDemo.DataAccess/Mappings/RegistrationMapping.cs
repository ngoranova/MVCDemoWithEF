using MvcDemo.Common.Entities;
using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations.Schema;

namespace MvcDemo.DataAccess.Mappings
{


    public class RegistrationMapping : EntityTypeConfiguration<Registration>
    {
        public const string TableName = "u_registration";

        public RegistrationMapping()
        {
            ToTable(TableName);
            this.Property(x => x.Id).IsRequired().HasColumnName("registration_id").HasDatabaseGeneratedOption(DatabaseGeneratedOption.None); //PK
            this.Property(x => x.OrderDetailId).IsOptional().HasColumnName("order_detail_id");
            this.Property(x => x.UserId).IsRequired().HasColumnName("user_id");
            this.Property(x => x.CoursePortalId).IsRequired().HasColumnName("course_portal_id");
            this.Property(x => x.RegistrationTime).IsRequired().HasColumnName("registration_dttm");
            this.Property(x => x.RegistrationTypeCode).IsRequired().HasColumnType("char").HasColumnName("registration_type_cd").HasMaxLength(3);
            this.Property(x => x.DropOutTime).IsOptional().HasColumnName("drop_out_dttm");
            this.Property(x => x.AccessStartDate).IsRequired().HasColumnName("access_start_dt");
            this.Property(x => x.AccessFinishDate).IsRequired().HasColumnName("access_finish_dt");
            this.Property(x => x.ActiveIndicator).IsRequired().HasColumnName("active_ind");
            this.Property(x => x.CreatedTime).IsRequired().HasColumnName("created_dttm");
            this.Property(x => x.CreatedId).IsRequired().HasColumnName("created_id");
            this.Property(x => x.ModifiedTime).IsOptional().HasColumnName("modified_dttm");
            this.Property(x => x.ModifiedId).IsOptional().HasColumnName("modified_id");
            this.Property(x => x.CompleteTime).IsOptional().HasColumnName("complete_dttm");
            this.Property(x => x.FinalGrade).HasPrecision(12, 4).IsOptional().HasColumnName("final_grade");
            this.Property(x => x.CoursePortalSelfRegistrationId).IsOptional().HasColumnName("course_portal_self_reg_id");
            this.Property(x => x.CreditUpgradeIndicator).IsOptional().HasColumnName("credit_upgrade_ind");
            this.Property(x => x.WithdrawnIndicator).IsRequired().HasColumnName("withdrawn_ind");
            this.Property(x => x.GradeId).IsOptional().HasColumnName("grade_id");
            this.Property(x => x.EnrollmentStatusId).IsRequired().HasColumnName("enrollment_status_id");
            this.Property(x => x.LastActivityDate).IsOptional().HasColumnName("last_activity_date");
            this.Property(x => x.ClusteredId).IsRequired().HasColumnName("clustered_id");

        }

       
    }
}
