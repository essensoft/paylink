using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayOpenMiniSafedomainDeleteModel Data Structure.
    /// </summary>
    public class AlipayOpenMiniSafedomainDeleteModel : AlipayObject
    {
        /// <summary>
        /// 服务器域名白名单。支付宝小程序在HTTP请求、上传文件等场景只能与域名白名单中的域名进行通讯 。 删除域白名单后需重新上传应用版本（模板模式下小程序模板及商家应用都需重新上传、实例化版本）才会生效。老版本应用继续使用老版本名单（即删除域名可继续使用）。
        /// </summary>
        [JsonPropertyName("safe_domain")]
        public string SafeDomain { get; set; }
    }
}
