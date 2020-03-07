using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayOpenMiniPlanOperateBatchqueryModel Data Structure.
    /// </summary>
    public class AlipayOpenMiniPlanOperateBatchqueryModel : AlipayObject
    {
        /// <summary>
        /// 页码数，从第一页开始
        /// </summary>
        [JsonPropertyName("page_num")]
        public long PageNum { get; set; }

        /// <summary>
        /// 每页记录数，默认10
        /// </summary>
        [JsonPropertyName("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 投放方案场景码，目前只支持支付后推荐场景：PAYMENT_SUCCESS
        /// </summary>
        [JsonPropertyName("scene")]
        public string Scene { get; set; }
    }
}
