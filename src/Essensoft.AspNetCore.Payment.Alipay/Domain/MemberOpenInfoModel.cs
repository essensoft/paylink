using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// MemberOpenInfoModel Data Structure.
    /// </summary>
    public class MemberOpenInfoModel : AlipayObject
    {
        /// <summary>
        /// 开卡连接，必须http、https开头
        /// </summary>
        [JsonPropertyName("open_url")]
        public string OpenUrl { get; set; }

        /// <summary>
        /// 微信端开卡链接，不能是alipay域名  如果会员模板支持微信端，则必填
        /// </summary>
        [JsonPropertyName("wechat_open_url")]
        public string WechatOpenUrl { get; set; }
    }
}
