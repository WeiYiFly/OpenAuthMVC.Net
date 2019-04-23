

namespace MVC.Repository.Mapping
{
    public partial class ModuleMap
        : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<MVC.Repository.Domain.Module>
    {
        public ModuleMap()
        {
            // table
            ToTable("Module", "dbo");

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
            Property(t => t.Url)
                .HasColumnName("Url")
                .HasMaxLength(255)
                .IsRequired();
            Property(t => t.HotKey)
                .HasColumnName("HotKey")
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
            Property(t => t.ParentName)
                .HasColumnName("ParentName")
                .HasMaxLength(255)
                .IsRequired();
            Property(t => t.Vector)
                .HasColumnName("Vector")
                .HasMaxLength(255)
                .IsRequired();
            Property(t => t.SortNo)
                .HasColumnName("SortNo")
                .IsRequired();
            Property(t => t.ParentId)
                .HasColumnName("ParentId")
                .HasMaxLength(50)
                .IsOptional();
            Property(t => t.Code)
                .HasColumnName("Code")
                .HasMaxLength(50)
                .IsOptional();

            // Relationships
        }
    }
}
