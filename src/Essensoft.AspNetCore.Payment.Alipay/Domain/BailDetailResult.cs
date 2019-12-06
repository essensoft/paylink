using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// BailDetailResult Data Structure.
    /// </summary>
    public class BailDetailResult : AlipayObject
    {
        /// <summary>
        /// 保证金收支金额
        /// </summary>
        [JsonPropertyName("amount")]
        public string Amount { get; set; }

        /// <summary>
        /// 保证金类型描述，仅供参考
        /// </summary>
        [JsonPropertyName("bail_type")]
        public string BailType { get; set; }

        /// <summary>
        /// 保证金余额
        /// </summary>
        [JsonPropertyName("balance")]
        public string Balance { get; set; }

        /// <summary>
        /// 业务描述，资金收支对应的详细业务场景信息
        /// </summary>
        [JsonPropertyName("biz_desc")]
        public string BizDesc { get; set; }

        /// <summary>
        /// 业务基础订单号，资金收支对应的原始业务订单唯一识别编号
        /// </summary>
        [JsonPropertyName("biz_orig_no")]
        public string BizOrigNo { get; set; }

        /// <summary>
        /// 保证金说明
        /// </summary>
        [JsonPropertyName("memo")]
        public string Memo { get; set; }

        /// <summary>
        /// 业务发生时间
        /// </summary>
        [JsonPropertyName("trans_dt")]
        public string TransDt { get; set; }

        /// <summary>
        /// 保证金业务流水号
        /// </summary>
        [JsonPropertyName("trans_log_id")]
        public string TransLogId { get; set; }
    }
}
