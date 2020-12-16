using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AnttechBlockchainFinanceAntdaoMypointsPublishModel Data Structure.
    /// </summary>
    public class AnttechBlockchainFinanceAntdaoMypointsPublishModel : AlipayObject
    {
        /// <summary>
        /// 数量
        /// </summary>
        [JsonPropertyName("count")]
        public long Count { get; set; }

        /// <summary>
        /// 备注信息
        /// </summary>
        [JsonPropertyName("memo")]
        public string Memo { get; set; }

        /// <summary>
        /// 方法路由
        /// </summary>
        [JsonPropertyName("method_name")]
        public string MethodName { get; set; }

        /// <summary>
        /// 商品ID
        /// </summary>
        [JsonPropertyName("sku_id")]
        public string SkuId { get; set; }
    }
}
