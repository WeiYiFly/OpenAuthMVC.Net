

namespace MVC.Repository.Mapping
{
    public partial class FlowInstanceTransitionHistoryMap
        : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<MVC.Repository.Domain.FlowInstanceTransitionHistory>
    {
        public FlowInstanceTransitionHistoryMap()
        {
            // table
            ToTable("FlowInstanceTransitionHistory", "dbo");

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
            Property(t => t.FromNodeId)
                .HasColumnName("FromNodeId")
                .HasMaxLength(50)
                .IsOptional();
            Property(t => t.FromNodeType)
                .HasColumnName("FromNodeType")
                .IsOptional();
            Property(t => t.FromNodeName)
                .HasColumnName("FromNodeName")
                .HasMaxLength(200)
                .IsOptional();
            Property(t => t.ToNodeId)
                .HasColumnName("ToNodeId")
                .HasMaxLength(50)
                .IsOptional();
            Property(t => t.ToNodeType)
                .HasColumnName("ToNodeType")
                .IsOptional();
            Property(t => t.ToNodeName)
                .HasColumnName("ToNodeName")
                .HasMaxLength(200)
                .IsOptional();
            Property(t => t.TransitionSate)
                .HasColumnName("TransitionSate")
                .IsRequired();
            Property(t => t.IsFinish)
                .HasColumnName("IsFinish")
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

            // Relationships
        }
    }
}
