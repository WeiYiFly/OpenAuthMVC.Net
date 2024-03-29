﻿

namespace MVC.Repository.Mapping
{
    public partial class FlowSchemeMap
        : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<MVC.Repository.Domain.FlowScheme>
    {
        public FlowSchemeMap()
        {
            // table
            ToTable("FlowScheme", "dbo");

            // keys
            HasKey(t => t.Id);

            // Properties
            Property(t => t.Id)
                .HasColumnName("Id")
                .HasMaxLength(50)
                .IsRequired();
            Property(t => t.SchemeCode)
                .HasColumnName("SchemeCode")
                .HasMaxLength(50)
                .IsOptional();
            Property(t => t.SchemeName)
                .HasColumnName("SchemeName")
                .HasMaxLength(200)
                .IsOptional();
            Property(t => t.SchemeType)
                .HasColumnName("SchemeType")
                .HasMaxLength(50)
                .IsOptional();
            Property(t => t.SchemeVersion)
                .HasColumnName("SchemeVersion")
                .HasMaxLength(50)
                .IsOptional();
            Property(t => t.SchemeCanUser)
                .HasColumnName("SchemeCanUser")
                .IsOptional();
            Property(t => t.SchemeContent)
                .HasColumnName("SchemeContent")
                .IsOptional();
            Property(t => t.FrmId)
                .HasColumnName("FrmId")
                .HasMaxLength(50)
                .IsOptional();
            Property(t => t.FrmType)
                .HasColumnName("FrmType")
                .IsRequired();
            Property(t => t.AuthorizeType)
                .HasColumnName("AuthorizeType")
                .IsRequired();
            Property(t => t.SortCode)
                .HasColumnName("SortCode")
                .IsRequired();
            Property(t => t.DeleteMark)
                .HasColumnName("DeleteMark")
                .IsRequired();
            Property(t => t.Disabled)
                .HasColumnName("Disabled")
                .IsRequired();
            Property(t => t.Description)
                .HasColumnName("Description")
                .HasMaxLength(200)
                .IsOptional();
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
            Property(t => t.ModifyDate)
                .HasColumnName("ModifyDate")
                .IsOptional();
            Property(t => t.ModifyUserId)
                .HasColumnName("ModifyUserId")
                .HasMaxLength(50)
                .IsOptional();
            Property(t => t.ModifyUserName)
                .HasColumnName("ModifyUserName")
                .HasMaxLength(50)
                .IsOptional();

            // Relationships
        }
    }
}
