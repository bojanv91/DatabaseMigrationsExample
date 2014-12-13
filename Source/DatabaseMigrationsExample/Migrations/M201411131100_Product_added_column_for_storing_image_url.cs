using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentMigrator;

namespace DatabaseMigrationsExample.Migrations
{
    [Migration(201411131100)]
    public class M201411131100_Product_added_column_for_storing_image_url : Migration
    {
        public override void Up()
        {
            Alter.Table("Product")
                .AddColumn("ImageUrl").AsString(255);
        }

        public override void Down()
        {
            Delete.Column("ImageUrl").FromTable("Product");
        }
    }
}
