using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// AlipayFundTransMergeDetailQueryModel Data Structure.
    /// </summary>
    public class AlipayFundTransMergeDetailQueryModel : AlipayObject
    {
        /// <summary>
        /// 业务的场景码
        /// </summary>
        [JsonPropertyName("biz_scene")]
        public string BizScene { get; set; }

        /// <summary>
        /// 支付宝返回的合并单据主单号
        /// </summary>
        [JsonPropertyName("merge_order_id")]
        public string MergeOrderId { get; set; }

        /// <summary>
        /// 产品码
        /// </summary>
        [JsonPropertyName("product_code")]
        public string ProductCode { get; set; }
    }
}
