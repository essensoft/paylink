using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// RefundUnfreezeResult Data Structure.
    /// </summary>
    public class RefundUnfreezeResult : AlipayObject
    {
        /// <summary>
        /// 冻结单号
        /// </summary>
        [JsonPropertyName("freeze_no")]
        public string FreezeNo { get; set; }

        /// <summary>
        /// 解冻结果码
        /// </summary>
        [JsonPropertyName("result_code")]
        public string ResultCode { get; set; }

        /// <summary>
        /// 解冻状态。S成功，F失败。
        /// </summary>
        [JsonPropertyName("status")]
        public string Status { get; set; }

        /// <summary>
        /// 解冻金额
        /// </summary>
        [JsonPropertyName("unfreeze_amount")]
        public string UnfreezeAmount { get; set; }

        /// <summary>
        /// 解冻单号
        /// </summary>
        [JsonPropertyName("unfreeze_no")]
        public string UnfreezeNo { get; set; }

        /// <summary>
        /// 解冻时间
        /// </summary>
        [JsonPropertyName("unfreeze_time")]
        public string UnfreezeTime { get; set; }
    }
}
