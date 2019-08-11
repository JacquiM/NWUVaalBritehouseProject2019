using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace AngelistStartupList.Models
{
    public partial class AngelistContext : DbContext
    {
        public AngelistContext()
        {
        }

        public AngelistContext(DbContextOptions<AngelistContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AfricanStartup> AfricanStartup { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=Angelist;Data Source=.\\LOCAL");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AfricanStartup>(entity =>
            {
                entity.HasKey(e => e.ListId);

                entity.Property(e => e.ListId).HasColumnName("list_id");

                entity.Property(e => e.AngellistUrl)
                    .HasColumnName("angellist_url")
                    .IsUnicode(false);

                entity.Property(e => e.BlogUrl)
                    .HasColumnName("blog_url")
                    .IsUnicode(false);

                entity.Property(e => e.CommunityProfile)
                    .HasColumnName("community_profile")
                    .IsUnicode(false);

                entity.Property(e => e.CompanySize)
                    .HasColumnName("company_size")
                    .IsUnicode(false);

                entity.Property(e => e.CompanyType)
                    .HasColumnName("company_type")
                    .IsUnicode(false);

                entity.Property(e => e.CompanyUrl)
                    .HasColumnName("company_url")
                    .IsUnicode(false);

                entity.Property(e => e.Country)
                    .HasColumnName("country")
                    .IsUnicode(false);

                entity.Property(e => e.CreatedAt)
                    .HasColumnName("created_at")
                    .IsUnicode(false);

                entity.Property(e => e.CrunchbaseUrl)
                    .HasColumnName("crunchbase_url")
                    .IsUnicode(false);

                entity.Property(e => e.FacebookUrl)
                    .HasColumnName("facebook_url")
                    .IsUnicode(false);

                entity.Property(e => e.FollowerCount)
                    .HasColumnName("follower_count")
                    .IsUnicode(false);

                entity.Property(e => e.HighConcept)
                    .HasColumnName("high_concept")
                    .IsUnicode(false);

                entity.Property(e => e.Id)
                    .HasColumnName("id")
                    .IsUnicode(false);

                entity.Property(e => e.LinkedinUrl)
                    .HasColumnName("linkedin_url")
                    .IsUnicode(false);

                entity.Property(e => e.Locations)
                    .HasColumnName("locations")
                    .IsUnicode(false);

                entity.Property(e => e.LogoUrl)
                    .HasColumnName("logo_url")
                    .IsUnicode(false);

                entity.Property(e => e.Markets)
                    .HasColumnName("markets")
                    .IsUnicode(false);

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .IsUnicode(false);

                entity.Property(e => e.ProductDesc)
                    .HasColumnName("product_desc")
                    .IsUnicode(false);

                entity.Property(e => e.Quality)
                    .HasColumnName("quality")
                    .IsUnicode(false);

                entity.Property(e => e.Screenshots)
                    .HasColumnName("screenshots")
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .IsUnicode(false);

                entity.Property(e => e.ThumbUrl)
                    .HasColumnName("thumb_url")
                    .IsUnicode(false);

                entity.Property(e => e.TwitterUrl)
                    .HasColumnName("twitter_url")
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedAt)
                    .HasColumnName("updated_at")
                    .IsUnicode(false);

                entity.Property(e => e.VideoUrl)
                    .HasColumnName("video_url")
                    .IsUnicode(false);
            });
        }
    }
}
