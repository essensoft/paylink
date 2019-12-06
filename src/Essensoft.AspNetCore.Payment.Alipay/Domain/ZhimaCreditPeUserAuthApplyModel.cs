using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// ZhimaCreditPeUserAuthApplyModel Data Structure.
    /// </summary>
    public class ZhimaCreditPeUserAuthApplyModel : AlipayObject
    {
        /// <summary>
        /// 产品码，固定值: w1010100001000002428
        /// </summary>
        [JsonPropertyName("product_code")]
        public string ProductCode { get; set; }

        /// <summary>
        /// 授权回调地址，是经过URLENCODE转义的url链接（url必须以http或者https开头）;在请求之前，开发者需要先到开发者中心对应应用内，配置授权回调地址。 redirect_uri与应用配置的授权回调地址域名部分必须一致。
        /// </summary>
        [JsonPropertyName("redirect_uri")]
        public string RedirectUri { get; set; }

        /// <summary>
        /// 接口权限值，目前只支持auth_user（获取用户信息、网站支付宝登录）、auth_base（用户信息授权）、auth_ecard（商户会员卡）、auth_invoice_info（支付宝闪电开票）、auth_puc_charge（生活缴费），auth_zhima等;多个scope时用”,”分隔，如scope为”auth_user,auth_ecard”时，此时获取到的access_token，既可以用来获取用户信息，又可以给用户发送会员卡。
        /// </summary>
        [JsonPropertyName("scope")]
        public string Scope { get; set; }

        /// <summary>
        /// 商户自定义参数，用户授权后，重定向到redirect_uri时会原样回传给商户。 为防止CSRF攻击，建议开发者请求授权时传入state参数，该参数要做到既不可预测，又可以证明客户端和当前第三方网站的登录认证状态存在关联。  只允许base64字符（长度小于等于100）
        /// </summary>
        [JsonPropertyName("state")]
        public string State { get; set; }
    }
}
