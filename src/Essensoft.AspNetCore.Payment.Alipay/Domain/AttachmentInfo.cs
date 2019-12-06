using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AttachmentInfo Data Structure.
    /// </summary>
    public class AttachmentInfo : AlipayObject
    {
        /// <summary>
        /// 支付宝返回的图片在文件存储平台的标识
        /// </summary>
        [JsonPropertyName("atta_url")]
        public string AttaUrl { get; set; }

        /// <summary>
        /// 图片名称
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// 附件类型,PROMO_PIC:营销物料照
        /// </summary>
        [JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
