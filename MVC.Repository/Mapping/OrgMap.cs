

namespace MVC.Repository.Mapping
{
    public partial class OrgMap
        : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<MVC.Repository.Domain.Org>
    {
        public OrgMap()
        {
            // table
            ToTable("Org", "dbo");

            // keys
            HasKey(t => t.Id);

            // Properties
            Property(t => t.Id)
                .HasColumnName("Id")
                .HasMaxLength(50)
                .IsRequired();
            Property(t => t.CascadeId)
                .HasColumnName("CascadeId")
                .HasMaxLength(255)
                .IsRequired();
            Property(t => t.Name)
                .HasColumnName("Name")
                .HasMaxLength(255)
                .IsRequired();
            Property(t => t.HotKey)
                .HasColumnName("HotKey")
                .HasMaxLength(255)
                .IsRequired();
            Property(t => t.ParentName)
                .HasColumnName("ParentName")
                .HasMaxLength(255)
                .IsRequired();
            Property(t => t.IsLeaf)
                .HasColumnName("IsLeaf")
                .IsRequired();
            Property(t => t.IsAutoExpand)
                .HasColumnName("IsAutoExpand")
                .IsRequired();
            Property(t => t.IconName)
                .HasColumnName("IconName")
                .HasMaxLength(255)
                .IsRequired();
            Property(t => t.Status)
                .HasColumnName("Status")
                .IsRequired();
            Property(t => t.BizCode)
                .HasColumnName("BizCode")
                .HasMaxLength(255)
                .IsRequired();
            Property(t => t.CustomCode)
                .HasColumnName("CustomCode")
                .HasMaxLength(4000)
                .IsRequired();
            Property(t => t.CreateTime)
                .HasColumnName("CreateTime")
                .IsRequired();
            Property(t => t.CreateId)
                .HasColumnName("CreateId")
                .IsRequired();
            Property(t => t.SortNo)
                .HasColumnName("SortNo")
                .IsRequired();
            Property(t => t.ParentId)
                .HasColumnName("ParentId")
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
