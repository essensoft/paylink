using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// MybankPaymentTradeDepositVerifyQueryResponse.
    /// </summary>
    public class MybankPaymentTradeDepositVerifyQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 申请日期，格式是yyyyMMddHHmmss
        /// </summary>
        [JsonPropertyName("apply_date")]
        public string ApplyDate { get; set; }

        /// <summary>
        /// 认证申请间隔时间（分钟）
        /// </summary>
        [JsonPropertyName("apply_interval")]
        public long ApplyInterval { get; set; }

        /// <summary>
        /// 打款验证已申请次数
        /// </summary>
        [JsonPropertyName("apply_times")]
        public long ApplyTimes { get; set; }

        /// <summary>
        /// 验款失效日期，格式是yyyyMMddHHmmss
        /// </summary>
        [JsonPropertyName("match_exp_date")]
        public string MatchExpDate { get; set; }

        /// <summary>
        /// 已验款次数
        /// </summary>
        [JsonPropertyName("match_times")]
        public long MatchTimes { get; set; }

        /// <summary>
        /// 每日最多打款验证申请次数
        /// </summary>
        [JsonPropertyName("max_apply_times_daily")]
        public long MaxApplyTimesDaily { get; set; }

        /// <summary>
        /// 最多验款次数
        /// </summary>
        [JsonPropertyName("max_match_times")]
        public long MaxMatchTimes { get; set; }

        /// <summary>
        /// 打款验证当前状态： ACCEPT - 已受理 SUCCESS - 验证成功 FAIL - 验证失败 REMITTING - 打款中 REMITTED - 已打款，待验款 REMIT_REFUND - 打款失败（退汇） REMIT_FAIL - 打款失败 EXPIRED - 申请已过期失效
        /// </summary>
        [JsonPropertyName("status")]
        public string Status { get; set; }

        /// <summary>
        /// 打款验证ID 打款验证受理后生成的一个唯一标识
        /// </summary>
        [JsonPropertyName("verify_id")]
        public string VerifyId { get; set; }
    }
}
