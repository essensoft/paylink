using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// InsClaim Data Structure.
    /// </summary>
    public class InsClaim : AlipayObject
    {
        /// <summary>
        /// 理赔因子;标准json 格式
        /// </summary>
        [JsonPropertyName("biz_data")]
        public string BizData { get; set; }

        /// <summary>
        /// 实际赔付金额 ;单位分
        /// </summary>
        [JsonPropertyName("claim_fee")]
        public long ClaimFee { get; set; }

        /// <summary>
        /// 赔案号
        /// </summary>
        [JsonPropertyName("claim_no")]
        public string ClaimNo { get; set; }

        /// <summary>
        /// 赔付时间
        /// </summary>
        [JsonPropertyName("claim_pay_time")]
        public string ClaimPayTime { get; set; }

        /// <summary>
        /// 赔案进度;根据更新时间倒序
        /// </summary>
        [JsonPropertyName("claim_progress")]
        public List<ClaimProgress> ClaimProgress { get; set; }

        /// <summary>
        /// 赔案状态.ACCEPTED:已受理;REJECTED:已拒赔;PAID:已赔付
        /// </summary>
        [JsonPropertyName("claim_status")]
        public string ClaimStatus { get; set; }

        /// <summary>
        /// 商户生成的外部理赔请求单号
        /// </summary>
        [JsonPropertyName("out_request_no")]
        public string OutRequestNo { get; set; }

        /// <summary>
        /// 当状态是拒赔时给出拒赔原因
        /// </summary>
        [JsonPropertyName("reject_reason")]
        public string RejectReason { get; set; }
    }
}
