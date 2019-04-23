using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC.Repository.Mapping
{
    public partial class UserMap
         : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<MVC.Repository.Domain.User>
    {
        public UserMap()
        {
            // table
            ToTable("User", "dbo");

            // keys
            HasKey(t => t.Id);

            // Properties
            Property(t => t.Id)
                .HasColumnName("Id")
                .HasMaxLength(50)
                .IsRequired();
            Property(t => t.Account)
                .HasColumnName("Account")
                .HasMaxLength(255)
                .IsRequired();
            Property(t => t.Password)
                .HasColumnName("Password")
                .HasMaxLength(255)
                .IsRequired();
            Property(t => t.Name)
                .HasColumnName("Name")
                .HasMaxLength(255)
                .IsRequired();
            Property(t => t.Sex)
                .HasColumnName("Sex")
                .IsRequired();
            Property(t => t.Status)
                .HasColumnName("Status")
                .IsRequired();
            Property(t => t.BizCode)
                .HasColumnName("BizCode")
                .HasMaxLength(255)
                .IsRequired();
            Property(t => t.CreateTime)
                .HasColumnName("CreateTime")
                .IsRequired();
            Property(t => t.CrateId)
                .HasColumnName("CrateId")
                .HasMaxLength(50)
                .IsOptional();
            Property(t => t.TypeName)
                .HasColumnName("TypeName")
                .HasMaxLength(20)
                .IsOptional();
            Property(t => t.TypeId)
                .HasColumnName("TypeId")
                .HasMaxLength(50)
                .IsOptional();

            // Relationships
        }
    }
}
