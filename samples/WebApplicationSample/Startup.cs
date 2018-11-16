using System;
using System.Security.Cryptography.X509Certificates;
using System.Text.Encodings.Web;
using System.Text.Unicode;
using Essensoft.AspNetCore.Payment.Alipay;
using Essensoft.AspNetCore.Payment.JDPay;
using Essensoft.AspNetCore.Payment.LianLianPay;
using Essensoft.AspNetCore.Payment.QPay;
using Essensoft.AspNetCore.Payment.UnionPay;
using Essensoft.AspNetCore.Payment.WeChatPay;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace WebApplicationSample
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.Configure<CookiePolicyOptions>(options =>
            {
                // This lambda determines whether user consent for non-essential cookies is needed for a given request.
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });

            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);

            services.AddAlipay();
            services.AddAlipayHttpClient();

            services.AddJDPay();
            services.AddJDPayHttpClient();

            services.AddQPay();
            services.AddQPayHttpClient();
            //services.AddQPayCertificateHttpClient(new X509Certificate2(Convert.FromBase64String(Configuration["QPay:Certificate"]), Configuration["QPay:MchId"], X509KeyStorageFlags.MachineKeySet));
            //services.AddQPayCertificateHttpClient("Default", new X509Certificate2(Convert.FromBase64String(Configuration["QPay:Certificate"]), Configuration["QPay:MchId"], X509KeyStorageFlags.MachineKeySet));

            services.AddUnionPay();
            services.AddUnionPayHttpClient();

            services.AddWeChatPay();
            services.AddWeChatPayHttpClient();
            //services.AddWeChatPayCertificateHttpClient(new X509Certificate2(Convert.FromBase64String(Configuration["WeChatPay:Certificate"]), Configuration["WeChatPay:MchId"], X509KeyStorageFlags.MachineKeySet));
            //services.AddWeChatPayCertificateHttpClient("Default", new X509Certificate2(Convert.FromBase64String(Configuration["WeChatPay:Certificate"]), Configuration["WeChatPay:MchId"], X509KeyStorageFlags.MachineKeySet));

            services.AddLianLianPay();
            services.AddLianLianPayHttpClient();

            services.Configure<AlipayOptions>(Configuration.GetSection("Alipay"));
            services.Configure<JDPayOptions>(Configuration.GetSection("JDPay"));
            services.Configure<QPayOptions>(Configuration.GetSection("QPay"));
            services.Configure<UnionPayOptions>(Configuration.GetSection("UnionPay"));
            services.Configure<WeChatPayOptions>(Configuration.GetSection("WeChatPay"));
            services.Configure<LianLianPayOptions>(Configuration.GetSection("LianLianPay"));

            services.AddWebEncoders(opt =>
            {
                opt.TextEncoderSettings = new TextEncoderSettings(UnicodeRanges.All);
            });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, ILoggerFactory loggerFactory)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }

            app.UseStaticFiles();

            app.UseCookiePolicy();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
