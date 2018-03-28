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

            // 参数配置 可参考以下两篇文章.

            // ASP.NET Core Web 支付功能接入 微信-扫码支付篇
            // http://www.cnblogs.com/essenroc/p/8630730.html
            // ASP.NET Core Web 支付功能接入 支付宝-电脑网页支付篇
            // https://www.cnblogs.com/essenroc/p/8627775.html

            services.AddAlipay();
            services.AddJdPay();
            services.AddQPay();
            services.AddUnionPay();
            services.AddWeChatPay();

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
