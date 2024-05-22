using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace tieuluan_ban_giay.Models.Mapping
{
    public class CommentMap : EntityTypeConfiguration<Comment>
    {
        public CommentMap()
        {
            
                // Primary Key
                this.HasKey(t => t.ID);


                // Table & Column Mappings
                this.ToTable("Comment");
                this.Property(t => t.ID).HasColumnName("ID");
                this.Property(t => t.CommentMsg).HasColumnName("CommentMsg");
                this.Property(t => t.CommentDate).HasColumnName("CommentDate");
                this.Property(t => t.ProductId).HasColumnName("ProductId");
                this.Property(t => t.CustomerId).HasColumnName("CustomerId");
                this.Property(t => t.ParentID).HasColumnName("ParentID");
                this.Property(t => t.Rate).HasColumnName("Rate");
            }
    }
}