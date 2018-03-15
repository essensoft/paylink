using Essensoft.AspNetCore.Alipay;
using Essensoft.AspNetCore.JdPay;
using Essensoft.AspNetCore.QPay;
using Essensoft.AspNetCore.UnionPay;
using Essensoft.AspNetCore.WeChatPay;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System.Text.Encodings.Web;
using System.Text.Unicode;

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
            services.AddMvc();

            // 添加依赖注入
            // 依赖注入介绍：https://docs.microsoft.com/zh-cn/aspnet/core/fundamentals/dependency-injection

            services.AddAlipay();
            services.AddWeChatPay();
            services.AddQPay();
            services.AddJdPay();
            services.AddUnionPay();

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
            services.Configure<UnionPayOptions>(Configuration.GetSection("UnionPay"));

            services.AddWebEncoders(opt =>
            {
                opt.TextEncoderSettings = new TextEncoderSettings(UnicodeRanges.All);
            });

            // 配置参数 具体参数见 AlipayOptions、WeChatPayOptions、QPayOptions、JdPayOptions、UnionPayOptions类

            //{
            //  "Alipay": {
            //    "AppId": "xxx",
            //    "RsaPublicKey": "xxx",
            //    "RsaPrivateKey": "xxx",
            //    "SignType" : "RSA2"
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
            //  "UnionPay": {
            //    "MerId": "xxx",
            //    "SignCert": "xxx",
            //    "SignCertPassword": "xxx",
            //    "EncryptCert": "xxx",
            //    "MiddleCert": "xxx",
            //    "RootCert": "xxx",
            //    "SecureKey": "xxx",
            //  }
            //}
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseBrowserLink();
                app.UseDeveloperExceptionPage();
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
