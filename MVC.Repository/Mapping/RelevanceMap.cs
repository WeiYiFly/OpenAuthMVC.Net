

namespace MVC.Repository.Mapping
{
    public partial class RelevanceMap
        : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<MVC.Repository.Domain.Relevance>
    {
        public RelevanceMap()
        {
            // table
            ToTable("Relevance", "dbo");

            // keys
            HasKey(t => t.Id);

            // Properties
            Property(t => t.Id)
                .HasColumnName("Id")
                .HasMaxLength(50)
                .IsRequired();
            Property(t => t.Description)
                .HasColumnName("Description")
                .HasMaxLength(100)
                .IsRequired();
            Property(t => t.Key)
                .HasColumnName("Key")
                .HasMaxLength(100)
                .IsRequired();
            Property(t => t.Status)
                .HasColumnName("Status")
                .IsRequired();
            Property(t => t.OperateTime)
                .HasColumnName("OperateTime")
                .IsRequired();
            Property(t => t.OperatorId)
                .HasColumnName("OperatorId")
                .HasMaxLength(50)
                .IsOptional();
            Property(t => t.FirstId)
                .HasColumnName("FirstId")
                .HasMaxLength(50)
                .IsRequired();
            Property(t => t.SecondId)
                .HasColumnName("SecondId")
                .HasMaxLength(50)
                .IsRequired();

            // Relationships
        }
    }
}
