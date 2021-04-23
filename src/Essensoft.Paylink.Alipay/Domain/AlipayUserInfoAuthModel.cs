using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// AlipayUserInfoAuthModel Data Structure.
    /// </summary>
    public class AlipayUserInfoAuthModel : AlipayObject
    {
        /// <summary>
        /// 接口权限值，枚举如下： * auth_base：以auth_base为scope发起的网页授权，用于获取进入页面的用户的 userId，并且是静默授权并自动跳转到回调页的。用户感知的就是直接进入了回调页（通常是业务页面）。  * auth_user：以auth_user为scope发起的网页授权，是用来获取用户的基本信息的（比如头像、昵称等）。但这种授权需要用户手动同意，用户同意后，就可在授权后获取到该用户的基本信息。
        /// </summary>
        [JsonPropertyName("scopes")]
        public List<string> Scopes { get; set; }

        /// <summary>
        /// 商户自定义参数，只允许base64字符（长度小于等于100）。 说明： * 传入时将在用户授权后，重定向到redirect_uri 时会原样回传给商户。 为防止CSRF攻击。 * 建议开发者请求授权时传入state参数，该参数要做到既不可预测，又可以证明客户端和当前第三方网站的登录认证状态存在关联。
        /// </summary>
        [JsonPropertyName("state")]
        public string State { get; set; }
    }
}
