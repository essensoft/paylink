using Essensoft.AspNetCore.Alipay;
using Essensoft.AspNetCore.JdPay;
using Essensoft.AspNetCore.QPay;
using Essensoft.AspNetCore.WeChatPay;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace WebApplicationSample
{
    public class Startup
    {
        public IConfiguration Configuration { get; }

        public Startup(IHostingEnvironment env)
        {
            var builder = new ConfigurationBuilder();

            if (env.IsDevelopment()) // 添加用户机密
            {
                builder.AddUserSecrets<Startup>();
            }

            Configuration = builder.Build();
        }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();

            services.AddAlipay();
            services.AddWeChatPay();
            services.AddQPay();
            services.AddJdPay();

            services.Configure<AlipayOptions>(Configuration.GetSection("Alipay"));
            services.Configure<WeChatPayOptions>(Configuration.GetSection("WeChatPay"));
            services.Configure<QPayOptions>(Configuration.GetSection("QPay"));
            services.Configure<JdPayOptions>(Configuration.GetSection("JdPay"));

            // 配置参数

            //{
            //  "Alipay": {
            //    "AppId": "xxx",
            //    "RsaPublicKey": "xxx",
            //    "RsaPrivateKey": "xxx"
            //  },
            //  "WeChatPay": {
            //    "AppId": "xxx",
            //    "AppSecret": "xxx",
            //    "MchId": "xxx",
            //    "Key": "xxx",
            //    "Certificate": "xxx",
            //    "RsaPublicKey": "xxx",
            //  },
            //  "QPay": {
            //    "MchId": "xxx",
            //    "Key": "xxx",
            //    "Certificate": "xxx",
            //  },
            //  "JdPay": {
            //    "Merchant": "xxx",
            //    "RsaPublicKey": "xxx",
            //    "RsaPrivateKey": "xxx",
            //    "DesKey": "xxx"
            //  }
            //}
        }

        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseBrowserLink();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
            }

            app.UseStaticFiles();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}
