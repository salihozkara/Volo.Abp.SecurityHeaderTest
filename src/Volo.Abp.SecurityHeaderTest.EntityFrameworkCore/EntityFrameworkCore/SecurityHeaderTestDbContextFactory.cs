using System;
using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace Volo.Abp.SecurityHeaderTest.EntityFrameworkCore;

/* This class is needed for EF Core console commands
 * (like Add-Migration and Update-Database commands) */
public class SecurityHeaderTestDbContextFactory : IDesignTimeDbContextFactory<SecurityHeaderTestDbContext>
{
    public SecurityHeaderTestDbContext CreateDbContext(string[] args)
    {
        SecurityHeaderTestEfCoreEntityExtensionMappings.Configure();

        var configuration = BuildConfiguration();

        var builder = new DbContextOptionsBuilder<SecurityHeaderTestDbContext>()
            .UseSqlServer(configuration.GetConnectionString("Default"));

        return new SecurityHeaderTestDbContext(builder.Options);
    }

    private static IConfigurationRoot BuildConfiguration()
    {
        var builder = new ConfigurationBuilder()
            .SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../Volo.Abp.SecurityHeaderTest.DbMigrator/"))
            .AddJsonFile("appsettings.json", optional: false);

        return builder.Build();
    }
}
