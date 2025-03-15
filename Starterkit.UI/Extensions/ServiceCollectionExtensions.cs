using Starterkit.UI._keenthemes.libs;
using Starterkit.UI._keenthemes;

namespace Starterkit.UI.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddWebServices(this IServiceCollection services)
        {
            services.AddControllersWithViews();

            services.AddScoped<IKTTheme, KTTheme>();
            services.AddSingleton<IKTBootstrapBase, KTBootstrapBase>();

            IConfiguration themeConfiguration = new ConfigurationBuilder()
                                        .AddJsonFile("_keenthemes/config/themesettings.json")
                                        .Build();

            IConfiguration iconsConfiguration = new ConfigurationBuilder()
                                        .AddJsonFile("_keenthemes/config/icons.json")
                                        .Build();

            KTThemeSettings.init(themeConfiguration);
            KTIconsSettings.init(iconsConfiguration);
            // Đăng ký các service cần thiết cho UI Layer
            services.ConfigureApplicationCookie(options =>
            {
                // Cookie settings
                options.Cookie.HttpOnly = true;
                options.ExpireTimeSpan = TimeSpan.FromMinutes(5);

                options.LoginPath = "/Identity/Account/Login";
                options.AccessDeniedPath = "/Identity/Account/AccessDenied";
                options.SlidingExpiration = true;
            });

            return services;
        }
    }
}
