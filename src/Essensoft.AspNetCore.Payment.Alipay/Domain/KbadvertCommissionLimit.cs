using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KbadvertCommissionLimit Data Structure.
    /// </summary>
    public class KbadvertCommissionLimit : AlipayObject
    {
        /// <summary>
        /// 推广者类型
        /// </summary>
        [JsonPropertyName("commission_user_type")]
        public string CommissionUserType { get; set; }

        /// <summary>
        /// 层级
        /// </summary>
        [JsonPropertyName("level")]
        public long Level { get; set; }

        /// <summary>
        /// 比例分佣的最大金额
        /// </summary>
        [JsonPropertyName("max_max_amount")]
        public string MaxMaxAmount { get; set; }

        /// <summary>
        /// 固定金额上限
        /// </summary>
        [JsonPropertyName("max_quota_amount")]
        public string MaxQuotaAmount { get; set; }

        /// <summary>
        /// 最小分佣比例
        /// </summary>
        [JsonPropertyName("min_commission_percentage")]
        public string MinCommissionPercentage { get; set; }

        /// <summary>
        /// 最小固定金额
        /// </summary>
        [JsonPropertyName("min_quota_amount")]
        public string MinQuotaAmount { get; set; }
    }
}
