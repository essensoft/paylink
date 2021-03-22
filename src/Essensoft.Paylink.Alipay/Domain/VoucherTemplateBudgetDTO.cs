using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// VoucherTemplateBudgetDTO Data Structure.
    /// </summary>
    public class VoucherTemplateBudgetDTO : AlipayObject
    {
        /// <summary>
        /// 当前可用余额，单位：分
        /// </summary>
        [JsonPropertyName("current_amount")]
        public long CurrentAmount { get; set; }

        /// <summary>
        /// 预算类型，MONEY代表金额，AMOUNT代表数量
        /// </summary>
        [JsonPropertyName("mode")]
        public string Mode { get; set; }

        /// <summary>
        /// 券模板ID
        /// </summary>
        [JsonPropertyName("template_id")]
        public string TemplateId { get; set; }

        /// <summary>
        /// 总预算金额，单位：分
        /// </summary>
        [JsonPropertyName("total_amount")]
        public long TotalAmount { get; set; }
    }
}
