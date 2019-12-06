using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// TopicItem Data Structure.
    /// </summary>
    public class TopicItem : AlipayObject
    {
        /// <summary>
        /// 内容图片url, 尺寸为300*300，最大不超过3M，支持格式:.jpg、.png ，请先调用<a href="https://docs.open.alipay.com/api_3/alipay.offline.material.image.upload"> 图片上传接口</a>获得图片url
        /// </summary>
        [JsonPropertyName("img_url")]
        public string ImgUrl { get; set; }

        /// <summary>
        /// 跳转链接，点击营销位内容图片跳到的链接url
        /// </summary>
        [JsonPropertyName("link_url")]
        public string LinkUrl { get; set; }

        /// <summary>
        /// 内容说明
        /// </summary>
        [JsonPropertyName("sub_title")]
        public string SubTitle { get; set; }

        /// <summary>
        /// 内容标题
        /// </summary>
        [JsonPropertyName("title")]
        public string Title { get; set; }
    }
}
