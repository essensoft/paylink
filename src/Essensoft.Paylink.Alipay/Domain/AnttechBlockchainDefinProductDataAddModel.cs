using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// AnttechBlockchainDefinProductDataAddModel Data Structure.
    /// </summary>
    public class AnttechBlockchainDefinProductDataAddModel : AlipayObject
    {
        /// <summary>
        /// 业务线编码 物流金融：LGCT
        /// </summary>
        [JsonPropertyName("biz_type")]
        public string BizType { get; set; }

        /// <summary>
        /// 自定义字段数据内容，支持json格式传输。具体字段结构由数据类型枚举值data_type决定
        /// </summary>
        [JsonPropertyName("data")]
        public CustomizeDataObject Data { get; set; }

        /// <summary>
        /// 上传数据的数据类型枚举，用于确定data字段的数据结构。 目前枚举值有 EXT_PRODUCT_INSTANCE：表示为商业中台产品实例类型。 目前仅支持提交商业中台产品实例数据，其他枚举值待后续扩展。
        /// </summary>
        [JsonPropertyName("data_type")]
        public string DataType { get; set; }
    }
}
