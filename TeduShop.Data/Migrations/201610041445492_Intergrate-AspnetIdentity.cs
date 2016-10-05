namespace TeduShop.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class IntergrateAspnetIdentity : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.IdentityRoles", newName: "AspNetRoles");
            RenameTable(name: "dbo.IdentityUserRoles", newName: "AspNetUserRoles");
            RenameTable(name: "dbo.ApplicationUsers", newName: "AspNetUsers");
            RenameTable(name: "dbo.IdentityUserClaims", newName: "AspNetUserClaims");
            RenameTable(name: "dbo.IdentityUserLogins", newName: "AspNetUserLogins");
            DropForeignKey("dbo.IdentityUserRoles", "IdentityRole_Id", "dbo.IdentityRoles");
            DropForeignKey("dbo.IdentityUserClaims", "ApplicationUser_Id", "dbo.ApplicationUsers");
            DropForeignKey("dbo.IdentityUserLogins", "ApplicationUser_Id", "dbo.ApplicationUsers");
            DropForeignKey("dbo.IdentityUserRoles", "ApplicationUser_Id", "dbo.ApplicationUsers");
            DropIndex("dbo.AspNetUserRoles", new[] { "IdentityRole_Id" });
            DropIndex("dbo.AspNetUserRoles", new[] { "ApplicationUser_Id" });
            DropIndex("dbo.AspNetUserClaims", new[] { "ApplicationUser_Id" });
            DropIndex("dbo.AspNetUserLogins", new[] { "ApplicationUser_Id" });
            DropColumn("dbo.AspNetUserRoles", "RoleId");
            DropColumn("dbo.AspNetUserRoles", "UserId");
            DropColumn("dbo.AspNetUserClaims", "UserId");
            DropColumn("dbo.AspNetUserLogins", "UserId");
            RenameColumn(table: "dbo.AspNetUserRoles", name: "IdentityRole_Id", newName: "RoleId");
            RenameColumn(table: "dbo.AspNetUserClaims", name: "ApplicationUser_Id", newName: "UserId");
            RenameColumn(table: "dbo.AspNetUserLogins", name: "ApplicationUser_Id", newName: "UserId");
            RenameColumn(table: "dbo.AspNetUserRoles", name: "ApplicationUser_Id", newName: "UserId");
            DropPrimaryKey("dbo.AspNetUserRoles");
            DropPrimaryKey("dbo.AspNetUserLogins");
            AlterColumn("dbo.AspNetRoles", "Name", c => c.String(nullable: false, maxLength: 256));
            AlterColumn("dbo.AspNetUserRoles", "RoleId", c => c.String(nullable: false, maxLength: 128));
            AlterColumn("dbo.AspNetUserRoles", "RoleId", c => c.String(nullable: false, maxLength: 128));
            AlterColumn("dbo.AspNetUserRoles", "UserId", c => c.String(nullable: false, maxLength: 128));
            AlterColumn("dbo.AspNetUsers", "Email", c => c.String(maxLength: 256));
            AlterColumn("dbo.AspNetUsers", "UserName", c => c.String(nullable: false, maxLength: 256));
            AlterColumn("dbo.AspNetUserClaims", "UserId", c => c.String(nullable: false, maxLength: 128));
            AlterColumn("dbo.AspNetUserClaims", "UserId", c => c.String(nullable: false, maxLength: 128));
            AlterColumn("dbo.AspNetUserLogins", "LoginProvider", c => c.String(nullable: false, maxLength: 128));
            AlterColumn("dbo.AspNetUserLogins", "ProviderKey", c => c.String(nullable: false, maxLength: 128));
            AlterColumn("dbo.AspNetUserLogins", "UserId", c => c.String(nullable: false, maxLength: 128));
            AddPrimaryKey("dbo.AspNetUserRoles", new[] { "UserId", "RoleId" });
            AddPrimaryKey("dbo.AspNetUserLogins", new[] { "LoginProvider", "ProviderKey", "UserId" });
            CreateIndex("dbo.AspNetRoles", "Name", unique: true, name: "RoleNameIndex");
            CreateIndex("dbo.AspNetUserRoles", "UserId");
            CreateIndex("dbo.AspNetUserRoles", "RoleId");
            CreateIndex("dbo.AspNetUsers", "UserName", unique: true, name: "UserNameIndex");
            CreateIndex("dbo.AspNetUserClaims", "UserId");
            CreateIndex("dbo.AspNetUserLogins", "UserId");
            AddForeignKey("dbo.AspNetUserRoles", "RoleId", "dbo.AspNetRoles", "Id", cascadeDelete: true);
            AddForeignKey("dbo.AspNetUserClaims", "UserId", "dbo.AspNetUsers", "Id", cascadeDelete: true);
            AddForeignKey("dbo.AspNetUserLogins", "UserId", "dbo.AspNetUsers", "Id", cascadeDelete: true);
            AddForeignKey("dbo.AspNetUserRoles", "UserId", "dbo.AspNetUsers", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.AspNetUserRoles", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserLogins", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserClaims", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserRoles", "RoleId", "dbo.AspNetRoles");
            DropIndex("dbo.AspNetUserLogins", new[] { "UserId" });
            DropIndex("dbo.AspNetUserClaims", new[] { "UserId" });
            DropIndex("dbo.AspNetUsers", "UserNameIndex");
            DropIndex("dbo.AspNetUserRoles", new[] { "RoleId" });
            DropIndex("dbo.AspNetUserRoles", new[] { "UserId" });
            DropIndex("dbo.AspNetRoles", "RoleNameIndex");
            DropPrimaryKey("dbo.AspNetUserLogins");
            DropPrimaryKey("dbo.AspNetUserRoles");
            AlterColumn("dbo.AspNetUserLogins", "UserId", c => c.String(maxLength: 128));
            AlterColumn("dbo.AspNetUserLogins", "ProviderKey", c => c.String());
            AlterColumn("dbo.AspNetUserLogins", "LoginProvider", c => c.String());
            AlterColumn("dbo.AspNetUserClaims", "UserId", c => c.String(maxLength: 128));
            AlterColumn("dbo.AspNetUserClaims", "UserId", c => c.String());
            AlterColumn("dbo.AspNetUsers", "UserName", c => c.String());
            AlterColumn("dbo.AspNetUsers", "Email", c => c.String());
            AlterColumn("dbo.AspNetUserRoles", "UserId", c => c.String(maxLength: 128));
            AlterColumn("dbo.AspNetUserRoles", "RoleId", c => c.String(maxLength: 128));
            AlterColumn("dbo.AspNetUserRoles", "RoleId", c => c.String());
            AlterColumn("dbo.AspNetRoles", "Name", c => c.String());
            AddPrimaryKey("dbo.AspNetUserLogins", "UserId");
            AddPrimaryKey("dbo.AspNetUserRoles", "UserId");
            RenameColumn(table: "dbo.AspNetUserRoles", name: "UserId", newName: "ApplicationUser_Id");
            RenameColumn(table: "dbo.AspNetUserLogins", name: "UserId", newName: "ApplicationUser_Id");
            RenameColumn(table: "dbo.AspNetUserClaims", name: "UserId", newName: "ApplicationUser_Id");
            RenameColumn(table: "dbo.AspNetUserRoles", name: "RoleId", newName: "IdentityRole_Id");
            AddColumn("dbo.AspNetUserLogins", "UserId", c => c.String(nullable: false, maxLength: 128));
            AddColumn("dbo.AspNetUserClaims", "UserId", c => c.String());
            AddColumn("dbo.AspNetUserRoles", "UserId", c => c.String(nullable: false, maxLength: 128));
            AddColumn("dbo.AspNetUserRoles", "RoleId", c => c.String());
            CreateIndex("dbo.AspNetUserLogins", "ApplicationUser_Id");
            CreateIndex("dbo.AspNetUserClaims", "ApplicationUser_Id");
            CreateIndex("dbo.AspNetUserRoles", "ApplicationUser_Id");
            CreateIndex("dbo.AspNetUserRoles", "IdentityRole_Id");
            AddForeignKey("dbo.IdentityUserRoles", "ApplicationUser_Id", "dbo.ApplicationUsers", "Id");
            AddForeignKey("dbo.IdentityUserLogins", "ApplicationUser_Id", "dbo.ApplicationUsers", "Id");
            AddForeignKey("dbo.IdentityUserClaims", "ApplicationUser_Id", "dbo.ApplicationUsers", "Id");
            AddForeignKey("dbo.IdentityUserRoles", "IdentityRole_Id", "dbo.IdentityRoles", "Id");
            RenameTable(name: "dbo.AspNetUserLogins", newName: "IdentityUserLogins");
            RenameTable(name: "dbo.AspNetUserClaims", newName: "IdentityUserClaims");
            RenameTable(name: "dbo.AspNetUsers", newName: "ApplicationUsers");
            RenameTable(name: "dbo.AspNetUserRoles", newName: "IdentityUserRoles");
            RenameTable(name: "dbo.AspNetRoles", newName: "IdentityRoles");
        }
    }
}
