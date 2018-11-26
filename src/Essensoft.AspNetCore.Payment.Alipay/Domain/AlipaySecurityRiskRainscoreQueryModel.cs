using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipaySecurityRiskRainscoreQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipaySecurityRiskRainscoreQueryModel : AlipayObject
    {
        /// <summary>
        /// 帐号内容，目前为中国大陆手机号（11位阿拉伯数字，不包含特殊符号或空格）
        /// </summary>
        [JsonProperty("account")]
        [XmlElement("account")]
        public string Account { get; set; }

        /// <summary>
        /// 账号类型，目前仅支持手机号（MOBILE_NO）
        /// </summary>
        [JsonProperty("account_type")]
        [XmlElement("account_type")]
        public string AccountType { get; set; }

        /// <summary>
        /// 调用服务的商户id ，如果是第三方服务商，需要将其实际的商户id透传过来，如果是普通商户传入自己的appid即可
        /// </summary>
        [JsonProperty("partner_id")]
        [XmlElement("partner_id")]
        public string PartnerId { get; set; }

        /// <summary>
        /// “蚁盾”风险评分服务版本号，当前版本为2.0
        /// </summary>
        [JsonProperty("version")]
        [XmlElement("version")]
        public string Version { get; set; }
    }
}
