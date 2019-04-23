﻿
namespace MVC.Repository.Mapping
{
    public partial class FlowInstanceMap
        : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<MVC.Repository.Domain.FlowInstance>
    {
        public FlowInstanceMap()
        {
            // table
            ToTable("FlowInstance", "dbo");

            // keys
            HasKey(t => t.Id);

            // Properties
            Property(t => t.Id)
                .HasColumnName("Id")
                .HasMaxLength(50)
                .IsRequired();
            Property(t => t.InstanceSchemeId)
                .HasColumnName("InstanceSchemeId")
                .HasMaxLength(50)
                .IsRequired();
            Property(t => t.Code)
                .HasColumnName("Code")
                .HasMaxLength(200)
                .IsOptional();
            Property(t => t.CustomName)
                .HasColumnName("CustomName")
                .HasMaxLength(200)
                .IsOptional();
            Property(t => t.ActivityId)
                .HasColumnName("ActivityId")
                .HasMaxLength(50)
                .IsOptional();
            Property(t => t.ActivityType)
                .HasColumnName("ActivityType")
                .IsOptional();
            Property(t => t.ActivityName)
                .HasColumnName("ActivityName")
                .HasMaxLength(200)
                .IsOptional();
            Property(t => t.PreviousId)
                .HasColumnName("PreviousId")
                .HasMaxLength(50)
                .IsOptional();
            Property(t => t.SchemeContent)
                .HasColumnName("SchemeContent")
                .IsOptional();
            Property(t => t.FrmData)
              .HasColumnName("FrmData")
              .IsOptional();
            Property(t => t.SchemeId)
                .HasColumnName("SchemeId")
                .HasMaxLength(50)
                .IsOptional();
            Property(t => t.DbName)
                .HasColumnName("DbName")
                .HasMaxLength(50)
                .IsOptional();
            Property(t => t.FrmType)
                .HasColumnName("FrmType")
                .IsRequired();
            Property(t => t.FrmContentData)
                .HasColumnName("FrmContentData")
                .IsOptional();
            Property(t => t.FrmContentParse)
                .HasColumnName("FrmContentParse")
                .IsOptional();
            Property(t => t.FrmId)
                .HasColumnName("FrmId")
                .HasMaxLength(50)
                .IsOptional();
            Property(t => t.SchemeType)
                .HasColumnName("SchemeType")
                .HasMaxLength(50)
                .IsOptional();
            Property(t => t.Disabled)
                .HasColumnName("Disabled")
                .IsRequired();
            Property(t => t.CreateDate)
                .HasColumnName("CreateDate")
                .IsRequired();
            Property(t => t.CreateUserId)
                .HasColumnName("CreateUserId")
                .HasMaxLength(50)
                .IsOptional();
            Property(t => t.CreateUserName)
                .HasColumnName("CreateUserName")
                .HasMaxLength(50)
                .IsOptional();
            Property(t => t.FlowLevel)
                .HasColumnName("FlowLevel")
                .IsRequired();
            Property(t => t.Description)
                .HasColumnName("Description")
                .HasMaxLength(200)
                .IsOptional();
            Property(t => t.IsFinish)
                .HasColumnName("IsFinish")
                .IsRequired();
            Property(t => t.MakerList)
                .HasColumnName("MakerList")
                .HasMaxLength(1000)
                .IsOptional();

            // Relationships
        }
    }
}
