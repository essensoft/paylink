using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// AlipayOpenPublicMessageContentCreateModel Data Structure.
    /// </summary>
    public class AlipayOpenPublicMessageContentCreateModel : AlipayObject
    {
        /// <summary>
        /// 活动利益点，最多10个字符。仅 ctype 为 activity 类型时才需传入。
        /// </summary>
        [JsonPropertyName("benefit")]
        public string Benefit { get; set; }

        /// <summary>
        /// 消息正文（支持富文本）
        /// </summary>
        [JsonPropertyName("content")]
        public string Content { get; set; }

        /// <summary>
        /// 是否允许评论。枚举支持： *T：允许。 *F：不允许，默认不允许。
        /// </summary>
        [JsonPropertyName("could_comment")]
        public string CouldComment { get; set; }

        /// <summary>
        /// 封面图url，需传入 <a href="https://opendocs.alipay.com/apis/api_3/alipay.offline.material.image.upload">图片上传接口</a>上传图片获取的 image_url。 注意：尺寸为 996*450，最大不超过3M，支持格式：jpg、.png 。
        /// </summary>
        [JsonPropertyName("cover")]
        public string Cover { get; set; }

        /// <summary>
        /// 图文类型，不填默认普通图文。还支持 activity（活动图文）。
        /// </summary>
        [JsonPropertyName("ctype")]
        public string Ctype { get; set; }

        /// <summary>
        /// 关键词列表，英文逗号分隔，最多不超过5个
        /// </summary>
        [JsonPropertyName("ext_tags")]
        public string ExtTags { get; set; }

        /// <summary>
        /// 可预览支付宝账号列表，需要预览时才填写， 英文逗号分隔，最多不超过10个
        /// </summary>
        [JsonPropertyName("login_ids")]
        public string LoginIds { get; set; }

        /// <summary>
        /// 标题
        /// </summary>
        [JsonPropertyName("title")]
        public string Title { get; set; }
    }
}
