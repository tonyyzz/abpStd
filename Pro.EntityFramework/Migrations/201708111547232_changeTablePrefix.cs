namespace Pro.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class changeTablePrefix : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.AbpAuditLogs", newName: "ProAuditLogs");
            RenameTable(name: "dbo.AbpBackgroundJobs", newName: "ProBackgroundJobs");
            RenameTable(name: "dbo.AbpFeatures", newName: "ProFeatures");
            RenameTable(name: "dbo.AbpEditions", newName: "ProEditions");
            RenameTable(name: "dbo.AbpLanguages", newName: "ProLanguages");
            RenameTable(name: "dbo.AbpLanguageTexts", newName: "ProLanguageTexts");
            RenameTable(name: "dbo.AbpNotifications", newName: "ProNotifications");
            RenameTable(name: "dbo.AbpNotificationSubscriptions", newName: "ProNotificationSubscriptions");
            RenameTable(name: "dbo.AbpOrganizationUnits", newName: "ProOrganizationUnits");
            RenameTable(name: "dbo.AbpPermissions", newName: "ProPermissions");
            RenameTable(name: "dbo.AbpRoles", newName: "ProRoles");
            RenameTable(name: "dbo.AbpUsers", newName: "ProUsers");
            RenameTable(name: "dbo.AbpUserClaims", newName: "ProUserClaims");
            RenameTable(name: "dbo.AbpUserLogins", newName: "ProUserLogins");
            RenameTable(name: "dbo.AbpUserRoles", newName: "ProUserRoles");
            RenameTable(name: "dbo.AbpSettings", newName: "ProSettings");
            RenameTable(name: "dbo.AbpTenantNotifications", newName: "ProTenantNotifications");
            RenameTable(name: "dbo.AbpTenants", newName: "ProTenants");
            RenameTable(name: "dbo.AbpUserAccounts", newName: "ProUserAccounts");
            RenameTable(name: "dbo.AbpUserLoginAttempts", newName: "ProUserLoginAttempts");
            RenameTable(name: "dbo.AbpUserNotifications", newName: "ProUserNotifications");
            RenameTable(name: "dbo.AbpUserOrganizationUnits", newName: "ProUserOrganizationUnits");
        }
        
        public override void Down()
        {
            RenameTable(name: "dbo.ProUserOrganizationUnits", newName: "AbpUserOrganizationUnits");
            RenameTable(name: "dbo.ProUserNotifications", newName: "AbpUserNotifications");
            RenameTable(name: "dbo.ProUserLoginAttempts", newName: "AbpUserLoginAttempts");
            RenameTable(name: "dbo.ProUserAccounts", newName: "AbpUserAccounts");
            RenameTable(name: "dbo.ProTenants", newName: "AbpTenants");
            RenameTable(name: "dbo.ProTenantNotifications", newName: "AbpTenantNotifications");
            RenameTable(name: "dbo.ProSettings", newName: "AbpSettings");
            RenameTable(name: "dbo.ProUserRoles", newName: "AbpUserRoles");
            RenameTable(name: "dbo.ProUserLogins", newName: "AbpUserLogins");
            RenameTable(name: "dbo.ProUserClaims", newName: "AbpUserClaims");
            RenameTable(name: "dbo.ProUsers", newName: "AbpUsers");
            RenameTable(name: "dbo.ProRoles", newName: "AbpRoles");
            RenameTable(name: "dbo.ProPermissions", newName: "AbpPermissions");
            RenameTable(name: "dbo.ProOrganizationUnits", newName: "AbpOrganizationUnits");
            RenameTable(name: "dbo.ProNotificationSubscriptions", newName: "AbpNotificationSubscriptions");
            RenameTable(name: "dbo.ProNotifications", newName: "AbpNotifications");
            RenameTable(name: "dbo.ProLanguageTexts", newName: "AbpLanguageTexts");
            RenameTable(name: "dbo.ProLanguages", newName: "AbpLanguages");
            RenameTable(name: "dbo.ProEditions", newName: "AbpEditions");
            RenameTable(name: "dbo.ProFeatures", newName: "AbpFeatures");
            RenameTable(name: "dbo.ProBackgroundJobs", newName: "AbpBackgroundJobs");
            RenameTable(name: "dbo.ProAuditLogs", newName: "AbpAuditLogs");
        }
    }
}
