using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AliTrustAlipayCert Data Structure.
    /// </summary>
    [Serializable]
    public class AliTrustAlipayCert : AlipayObject
    {
        /// <summary>
        /// 用户出生日期
        /// </summary>
        [JsonProperty("birthday")]
        public string Birthday { get; set; }

        /// <summary>
        /// 点击支付宝实名认证图标之后的跳转链接
        /// </summary>
        [JsonProperty("forward_url")]
        public string ForwardUrl { get; set; }

        /// <summary>
        /// 用户性别(M/F)
        /// </summary>
        [JsonProperty("gender")]
        public string Gender { get; set; }

        /// <summary>
        /// 支付宝实名认证图标的链接地址
        /// </summary>
        [JsonProperty("icon_url")]
        public string IconUrl { get; set; }

        /// <summary>
        /// 当账户为支付宝实名认证时,取值为"T";否则为"F".
        /// </summary>
        [JsonProperty("is_certified")]
        public string IsCertified { get; set; }

        /// <summary>
        /// 用户姓名
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }
    }
}
