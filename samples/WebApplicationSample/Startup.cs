using Essensoft.AspNetCore.Payment.Alipay;
using Essensoft.AspNetCore.Payment.JdPay;
using Essensoft.AspNetCore.Payment.QPay;
using Essensoft.AspNetCore.Payment.UnionPay;
using Essensoft.AspNetCore.Payment.WeChatPay;
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
            services.AddJdPay();
            services.AddQPay();
            services.AddUnionPay();
            services.AddWeChatPay();

            // 可在添加依赖注入时设置参数
            // 例如：
            //services.AddAlipay(opt =>
            //{
            //    //一般设置 AppId、RsaPrivateKey、RsaPublicKey，其余默认即可.
            //    //此处为蚂蚁金服开放平台上创建的APPID，而非老版本的商户号
            //    opt.AppId = "";

            //    // 这里的公私钥 默认均为支付宝官方推荐使用的RSAWithSHA256.
            //    // 商户私钥
            //    opt.RsaPrivateKey = "";
            //    // 支付宝公钥
            //    opt.RsaPublicKey = "";
            //});

            // 配置介绍： https://docs.microsoft.com/zh-cn/aspnet/core/fundamentals/configuration?tabs=basicconfiguration
            // 用户机密介绍： https://docs.microsoft.com/zh-cn/aspnet/core/security/app-secrets?tabs=visual-studio

            // 注册配置实例(使用配置文件或用户机密的方式设置参数)
            services.Configure<AlipayOptions>(Configuration.GetSection("Alipay"));
            services.Configure<JdPayOptions>(Configuration.GetSection("JdPay"));
            services.Configure<QPayOptions>(Configuration.GetSection("QPay"));
            services.Configure<UnionPayOptions>(Configuration.GetSection("UnionPay"));
            services.Configure<WeChatPayOptions>(Configuration.GetSection("WeChatPay"));

            services.AddWebEncoders(opt =>
            {
                opt.TextEncoderSettings = new TextEncoderSettings(UnicodeRanges.All);
            });

            // Json格式 配置参数. 具体参数见 AlipayOptions、JdPayOptions、QPayOptions、UnionPayOptions、WeChatPayOptions类

            //{
            //  "Alipay": {
            //    "AppId": "xxx",
            //    "RsaPublicKey": "xxx",
            //    "RsaPrivateKey": "xxx",
            //    "SignType" : "RSA2"
            //  },
            //  "JdPay": {
            //    "Merchant": "xxx",
            //    "RsaPublicKey": "xxx",
            //    "RsaPrivateKey": "xxx",
            //    "DesKey": "xxx"
            //  },
            //  "QPay": {
            //    "MchId": "xxx",
            //    "Key": "xxx",
            //    "Certificate": "xxx",
            //  },
            //  "UnionPay": {
            //    "MerId": "xxx",
            //    "SignCert": "xxx",
            //    "SignCertPassword": "xxx",
            //    "EncryptCert": "xxx",
            //    "MiddleCert": "xxx",
            //    "RootCert": "xxx",
            //    "SecureKey": "xxx",
            //  },
            //  "WeChatPay": {
            //    "AppId": "xxx",
            //    "MchId": "xxx",
            //    "Key": "xxx",
            //    "Certificate": "xxx",
            //    "RsaPublicKey": "xxx",
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
