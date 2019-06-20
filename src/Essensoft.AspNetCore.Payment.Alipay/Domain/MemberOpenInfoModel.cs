using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// MemberOpenInfoModel Data Structure.
    /// </summary>
    [Serializable]
    public class MemberOpenInfoModel : AlipayObject
    {
        /// <summary>
        /// 开卡连接，必须http、https开头
        /// </summary>
        [JsonProperty("open_url")]
        public string OpenUrl { get; set; }

        /// <summary>
        /// 微信端开卡链接，不能是alipay域名  如果会员模板支持微信端，则必填
        /// </summary>
        [JsonProperty("wechat_open_url")]
        public string WechatOpenUrl { get; set; }
    }
}
