using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// PrizeInfo Data Structure.
    /// </summary>
    public class PrizeInfo : AlipayObject
    {
        /// <summary>
        /// 奖品使用地址
        /// </summary>
        [JsonPropertyName("activity_url")]
        public string ActivityUrl { get; set; }

        /// <summary>
        /// 脱敏后的支付宝登陆账号
        /// </summary>
        [JsonPropertyName("alipay_logon_id")]
        public string AlipayLogonId { get; set; }

        /// <summary>
        /// 奖品金额,单位为元
        /// </summary>
        [JsonPropertyName("amount")]
        public string Amount { get; set; }

        /// <summary>
        /// 奖品描述信息
        /// </summary>
        [JsonPropertyName("desc")]
        public string Desc { get; set; }

        /// <summary>
        /// 奖品发放时间，格式为yyyy-MM-dd HH:mm:ss；有多个奖品时按发放时间倒序排列
        /// </summary>
        [JsonPropertyName("gmt_create")]
        public string GmtCreate { get; set; }

        /// <summary>
        /// 奖品过期时间，格式为yyyy-MM-dd HH:mm:ss
        /// </summary>
        [JsonPropertyName("gmt_expired")]
        public string GmtExpired { get; set; }

        /// <summary>
        /// 奖品ID
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; }

        /// <summary>
        /// 奖品名称
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// 奖品状态，可枚举，分别为“可用”(ENABLED)、“不可用”(DISABLED)、“未激活”(UNACTIVATED)
        /// </summary>
        [JsonPropertyName("status")]
        public string Status { get; set; }
    }
}
