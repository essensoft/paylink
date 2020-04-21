using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayOverseasTravelContentCreateModel Data Structure.
    /// </summary>
    public class AlipayOverseasTravelContentCreateModel : AlipayObject
    {
        /// <summary>
        /// 内容作者
        /// </summary>
        [JsonPropertyName("author")]
        public string Author { get; set; }

        /// <summary>
        /// 内容分类code
        /// </summary>
        [JsonPropertyName("category_code")]
        public string CategoryCode { get; set; }

        /// <summary>
        /// 内容分类名称
        /// </summary>
        [JsonPropertyName("category_name")]
        public string CategoryName { get; set; }

        /// <summary>
        /// 内容详情，不包含页面样式
        /// </summary>
        [JsonPropertyName("content")]
        public string Content { get; set; }

        /// <summary>
        /// 内容id
        /// </summary>
        [JsonPropertyName("content_id")]
        public string ContentId { get; set; }

        /// <summary>
        /// 内容封面
        /// </summary>
        [JsonPropertyName("cover")]
        public string Cover { get; set; }

        /// <summary>
        /// 内容详情H5链接
        /// </summary>
        [JsonPropertyName("detail_url")]
        public string DetailUrl { get; set; }

        /// <summary>
        /// 图片链接列表，单个image大小不超过4096，image个数不超过50
        /// </summary>
        [JsonPropertyName("image_list")]
        public List<string> ImageList { get; set; }

        /// <summary>
        /// 内容修改时间，请确保本次修改的时间大于上一次修改的时间
        /// </summary>
        [JsonPropertyName("modified_date")]
        public long ModifiedDate { get; set; }

        /// <summary>
        /// poi列表，单个poi名称大小不超过512，poi个数不超过50个
        /// </summary>
        [JsonPropertyName("poi_list")]
        public List<ContentPoiData> PoiList { get; set; }

        /// <summary>
        /// 内容发布时间
        /// </summary>
        [JsonPropertyName("publish_date")]
        public long PublishDate { get; set; }

        /// <summary>
        /// 标签列表，单个tag大小不超过128，tag个数不超过1000
        /// </summary>
        [JsonPropertyName("tag_list")]
        public List<string> TagList { get; set; }

        /// <summary>
        /// 内容标题
        /// </summary>
        [JsonPropertyName("title")]
        public string Title { get; set; }
    }
}
