using DataBase.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace DataBase.Model_Config
{
    class Addresses_costumers_Config : IEntityTypeConfiguration<Address_costumers>
    {
        public void Configure(EntityTypeBuilder<Address_costumers> builder)
        {
            builder.HasKey(a => a.Address_ID);
            builder.HasOne(c => c.costumers).WithMany(a => a.Address).HasForeignKey(c => c.costumers_ID);
            builder.Property(s => s.Street_Name).HasColumnName("Street Name").IsRequired();
            builder.Property(s => s.House_Number).HasColumnName("House Number").IsRequired();
            builder.Property(s => s.Apartment_Number).HasColumnName("Apartment Number").IsRequired();
            builder.Property(s => s.Zipcode).HasColumnName("Zipcode").IsRequired();
            builder.Property(s => s.City).HasColumnName("City").IsRequired();
            
        }
    }
}
