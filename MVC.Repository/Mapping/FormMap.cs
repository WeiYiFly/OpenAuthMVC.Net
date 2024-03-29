﻿

namespace MVC.Repository.Mapping
{
    public partial class FormMap
        : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<MVC.Repository.Domain.Form>
    {
        public FormMap()
        {
            // table
            ToTable("Form", "dbo");

            // keys
            HasKey(t => t.Id);

            // Properties
            Property(t => t.Id)
                .HasColumnName("Id")
                .HasMaxLength(50)
                .IsRequired();
            Property(t => t.Name)
                .HasColumnName("Name")
                .HasMaxLength(200)
                .IsOptional();
            Property(t => t.Fields)
                .HasColumnName("Fields")
                .IsRequired();
            Property(t => t.ContentData)
                .HasColumnName("ContentData")
                .IsOptional();
            Property(t => t.ContentParse)
                .HasColumnName("ContentParse")
                .IsOptional();
            Property(t => t.Content)
                .HasColumnName("Content")
                .IsOptional();
            Property(t => t.SortCode)
                .HasColumnName("SortCode")
                .IsRequired();
            Property(t => t.Delete)
                .HasColumnName("Delete")
                .IsRequired();
            Property(t => t.DbName)
                .HasColumnName("DbName")
                .HasMaxLength(50)
                .IsOptional();
            Property(t => t.Enabled)
                .HasColumnName("Enabled")
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
