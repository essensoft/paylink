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

            // 添加依赖注入
            // 依赖注入介绍：https://docs.microsoft.com/zh-cn/aspnet/core/fundamentals/dependency-injection

            services.AddAlipay();
            services.AddWeChatPay();
            services.AddQPay();
            services.AddJdPay();

            // 添加依赖注入时，也可以直接设置参数..
            // 如：
            //services.AddAlipay(Option =>
            //{
            //    Option.AppId = "xxx";
            //    Option.RsaPublicKey = "xxx";
            //});

            // 配置介绍： https://docs.microsoft.com/zh-cn/aspnet/core/fundamentals/configuration?tabs=basicconfiguration
            // 用户机密介绍： https://docs.microsoft.com/zh-cn/aspnet/core/security/app-secrets?tabs=visual-studio

            // 注册配置实例(使用配置文件或用户机密的方式设置参数)
            services.Configure<AlipayOptions>(Configuration.GetSection("Alipay"));
            services.Configure<WeChatPayOptions>(Configuration.GetSection("WeChatPay"));
            services.Configure<QPayOptions>(Configuration.GetSection("QPay"));
            services.Configure<JdPayOptions>(Configuration.GetSection("JdPay"));

            // 配置参数 具体参数见 AlipayOptions、WeChatPayOptions、QPayOptions、JdPayOptions

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
