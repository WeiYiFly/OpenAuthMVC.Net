

namespace MVC.Repository.Mapping
{
    public partial class FlowInstanceOperationHistoryMap
        : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<MVC.Repository.Domain.FlowInstanceOperationHistory>
    {
        public FlowInstanceOperationHistoryMap()
        {
            // table
            ToTable("FlowInstanceOperationHistory", "dbo");

            // keys
            HasKey(t => t.Id);

            // Properties
            Property(t => t.Id)
                .HasColumnName("Id")
                .HasMaxLength(50)
                .IsRequired();
            Property(t => t.InstanceId)
                .HasColumnName("InstanceId")
                .HasMaxLength(50)
                .IsRequired();
            Property(t => t.Content)
                .HasColumnName("Content")
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

            // Relationships
        }
    }
}
