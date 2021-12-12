using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataBase.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace DataBase.Model_Config
{
    class Addresses_customerss_Config : IEntityTypeConfiguration<Address_customerss>
    {
        public void Configure(EntityTypeBuilder<Address_customerss> builder)
        {
            builder.HasKey(a => a.Address_ID);
            builder.HasOne(c => c.customers).WithMany(a => a.Address).HasForeignKey(c => c.customers_ID);
            builder.Property(s => s.Street_Name).HasColumnName("Street Name").IsRequired();
            builder.Property(s => s.House_Number).HasColumnName("House Number").IsRequired();
            builder.Property(s => s.Apartment_Number).HasColumnName("Apartment Number").IsRequired();
            builder.Property(s => s.Zipcode).HasColumnName("Zipcode").IsRequired();
            builder.Property(s => s.City).HasColumnName("City").IsRequired();
            
        }
    }
}
