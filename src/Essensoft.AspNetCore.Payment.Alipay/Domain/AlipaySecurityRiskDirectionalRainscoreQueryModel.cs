using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipaySecurityRiskDirectionalRainscoreQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipaySecurityRiskDirectionalRainscoreQueryModel : AlipayObject
    {
        /// <summary>
        /// 帐号内容，目前为中国大陆手机号（11位阿拉伯数字，不包含特殊符号或空格）
        /// </summary>
        [JsonProperty("account")]
        public string Account { get; set; }

        /// <summary>
        /// 账号类型，目前仅支持手机号（MOBILE_NO）
        /// </summary>
        [JsonProperty("account_type")]
        public string AccountType { get; set; }

        /// <summary>
        /// “蚁盾”风险评分服务版本号，当前版本为2.0
        /// </summary>
        [JsonProperty("version")]
        public string Version { get; set; }
    }
}
