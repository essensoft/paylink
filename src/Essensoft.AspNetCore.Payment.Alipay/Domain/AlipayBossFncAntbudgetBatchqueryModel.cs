using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayBossFncAntbudgetBatchqueryModel Data Structure.
    /// </summary>
    public class AlipayBossFncAntbudgetBatchqueryModel : AlipayObject
    {
        /// <summary>
        /// COMMISSION("COMMISSION", "返佣"),     PURCHASE("PURCHASE", "采购"),     PROMO("PROMO", "营销"),
        /// </summary>
        [JsonPropertyName("biz_type")]
        public string BizType { get; set; }

        /// <summary>
        /// 操作者，不可为空，域账号,
        /// </summary>
        [JsonPropertyName("operator")]
        public string Operator { get; set; }

        /// <summary>
        /// 分页页数，从1开始
        /// </summary>
        [JsonPropertyName("page_num")]
        public long PageNum { get; set; }

        /// <summary>
        /// 分页大小
        /// </summary>
        [JsonPropertyName("page_size")]
        public long PageSize { get; set; }
    }
}
