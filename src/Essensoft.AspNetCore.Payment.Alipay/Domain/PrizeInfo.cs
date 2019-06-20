using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// PrizeInfo Data Structure.
    /// </summary>
    [Serializable]
    public class PrizeInfo : AlipayObject
    {
        /// <summary>
        /// 奖品使用地址
        /// </summary>
        [JsonProperty("activity_url")]
        public string ActivityUrl { get; set; }

        /// <summary>
        /// 脱敏后的支付宝登陆账号
        /// </summary>
        [JsonProperty("alipay_logon_id")]
        public string AlipayLogonId { get; set; }

        /// <summary>
        /// 奖品金额,单位为元
        /// </summary>
        [JsonProperty("amount")]
        public string Amount { get; set; }

        /// <summary>
        /// 奖品描述信息
        /// </summary>
        [JsonProperty("desc")]
        public string Desc { get; set; }

        /// <summary>
        /// 奖品发放时间，格式为yyyy-MM-dd HH:mm:ss；有多个奖品时按发放时间倒序排列
        /// </summary>
        [JsonProperty("gmt_create")]
        public string GmtCreate { get; set; }

        /// <summary>
        /// 奖品过期时间，格式为yyyy-MM-dd HH:mm:ss
        /// </summary>
        [JsonProperty("gmt_expired")]
        public string GmtExpired { get; set; }

        /// <summary>
        /// 奖品ID
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; }

        /// <summary>
        /// 奖品名称
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// 奖品状态，可枚举，分别为“可用”(ENABLED)、“不可用”(DISABLED)、“未激活”(UNACTIVATED)
        /// </summary>
        [JsonProperty("status")]
        public string Status { get; set; }
    }
}
