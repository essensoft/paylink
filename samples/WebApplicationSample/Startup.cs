using System;
using System.Buffers.Text;
using System.Net.Http;
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

            // 引入HttpClient
            services.AddHttpClient();

            //引入HttpClient API证书的使用(仅QPay / WeChatPay的部分API使用到)。
            //services.AddHttpClient("qpayCertificateName").ConfigurePrimaryHttpMessageHandler(() =>
            //{
            //    var certificate = new X509Certificate2("", "", X509KeyStorageFlags.MachineKeySet);
            //    var handler = new HttpClientHandler();
            //    handler.ClientCertificates.Add(certificate);
            //    return handler;
            //});

            services.AddHttpClient("wechatpayCertificateName").ConfigurePrimaryHttpMessageHandler(() =>
            {
                var certificate = new X509Certificate2(Convert.FromBase64String(Configuration["WeChatPay:Certificate"]), Configuration["WeChatPay:MchId"], X509KeyStorageFlags.MachineKeySet);
                var handler = new HttpClientHandler();
                handler.ClientCertificates.Add(certificate);
                return handler;
            });

            // 引入Payment 依赖注入
            services.AddAlipay();
            services.AddJDPay();
            services.AddQPay();
            services.AddUnionPay();
            services.AddWeChatPay();
            services.AddLianLianPay();

            // 在 appsettings.json 中 配置选项
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

            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);
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
                    "default",
                    "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
