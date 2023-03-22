using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using Syncfusion.Blazor;
using SyncGanttDemo.Data;

namespace SyncGanttDemo
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddRazorPages();
            builder.Services.AddServerSideBlazor();
            builder.Services.AddSingleton<WeatherForecastService>();
            builder.Services.AddSyncfusionBlazor();

            var app = builder.Build();

            Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("MTM5ODUwOUAzMjMwMmUzNDJlMzBIOVNYV01HU090U0U1QnRPcFlyWkxXNG83RmRwWk1ubVo2aUErOWZ3bmJRPQ==;Mgo DSMBaFt/QHRqVVhkVFpHaV1LQmFJfFBmRGldf1RyckU3HVdTRHRcQl5hS35SckVhX31ZdXA=;Mgo DSMBMAY9C3t2VVhkQlFacldJXnxLd0x0RWFab196cFVMYlpBNQtUQF1hSn5QdEdjWHtecnJXT2FY;Mgo DSMBPh8sVXJ0S0J XE9AflRBQmFAYVF2R2BJflR0dF9EZkwgOX1dQl9gSX1RdEViXX9cdndVT2Q=;MTM5ODUxM0AzMjMwMmUzNDJlMzBGSC8rWVE2Y1hTVWE4NDdVcjc4WXp1TWprTnlUU0dBdVJZbXE4dG1lSm00PQ==;NRAiBiAaIQQuGjN/V0Z WE9EaFtKVmBWfFppR2NbfE5xflFGal5XVAciSV9jS31TdUdhWX5acHZTRWVeVQ==;ORg4AjUWIQA/Gnt2VVhkQlFacldJXnxLd0x0RWFab196cFVMYlpBNQtUQF1hSn5QdEdjWHtecnJWQGdY;MTM5ODUxNkAzMjMwMmUzNDJlMzBGWlpDd09Kckg4VFVsTnphVldVNnV5eTg1S21IRG43Sm8rN2lGMkdGYkE4PQ==;MTM5ODUxN0AzMjMwMmUzNDJlMzBXMFVLdXlxcXJmSEZZZThiZnlJMkZJQ2R1VGkveDZObzlYL3ZpY2VmR1cwPQ==;MTM5ODUxOEAzMjMwMmUzNDJlMzBNalcrMnRQNTRVNjZJVjFjelk0TFA5S0dOcVVEUW9vczIyTVFTMURORUdnPQ==;MTM5ODUxOUAzMjMwMmUzNDJlMzBkNkpsMVV4YU9zYzkvOW8zQ2lPNVdmWWhiVDlWeDZXdFlKeElGRERSSFRjPQ==;MTM5ODUyMEAzMjMwMmUzNDJlMzBIOVNYV01HU090U0U1QnRPcFlyWkxXNG83RmRwWk1ubVo2aUErOWZ3bmJRPQ==");

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();

            app.UseStaticFiles();

            app.UseRouting();

            app.MapBlazorHub();
            app.MapFallbackToPage("/_Host");

            app.Run();
        }
    }
}