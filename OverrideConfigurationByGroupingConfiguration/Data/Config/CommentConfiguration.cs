using ConfigurationByConvention.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace OverrideConfigurationByGroupingConfiguration.Data.Config
{
    public class CommentConfiguration : IEntityTypeConfiguration<Comment>
    {
        public void Configure(EntityTypeBuilder<Comment> builder)
        {
            builder.ToTable("tblComments");
            builder.Property(p => p.CommentBy).HasColumnName("UserId");
        }
    }

}
