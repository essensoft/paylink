using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// PromoContentApiSchemaVO Data Structure.
    /// </summary>
    public class PromoContentApiSchemaVO : AlipayObject
    {
        /// <summary>
        /// 内容的配置示意图
        /// </summary>
        [JsonPropertyName("demo_pic")]
        public string DemoPic { get; set; }

        /// <summary>
        /// 内容的元数据ID
        /// </summary>
        [JsonPropertyName("schema_id")]
        public string SchemaId { get; set; }

        /// <summary>
        /// xml格式的schema；这里规定了场景素材需要的字段，字段的类型以及字段的规则要求。 场景素材中的图片字段，要求上传的是这个图片在文件存储平台的标识即图片文件ID（详见接口alipay.open.app.service.image.upload）
        /// </summary>
        [JsonPropertyName("schema_xml")]
        public string SchemaXml { get; set; }
    }
}
