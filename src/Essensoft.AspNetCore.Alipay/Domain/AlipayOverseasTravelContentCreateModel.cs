using Newtonsoft.Json;
using System.Collections.Generic;

namespace Essensoft.AspNetCore.Alipay.Domain
{
    /// <summary>
    /// AlipayOverseasTravelContentCreateModel Data Structure.
    /// </summary>
    public class AlipayOverseasTravelContentCreateModel : AlipayObject
    {
        /// <summary>
        /// 内容作者
        /// </summary>
        [JsonProperty("author")]
        public string Author { get; set; }

        /// <summary>
        /// 内容分类code
        /// </summary>
        [JsonProperty("category_code")]
        public string CategoryCode { get; set; }

        /// <summary>
        /// 内容分类名称
        /// </summary>
        [JsonProperty("category_name")]
        public string CategoryName { get; set; }

        /// <summary>
        /// 内容详情，不包含页面样式
        /// </summary>
        [JsonProperty("content")]
        public string Content { get; set; }

        /// <summary>
        /// 飞猪内容id
        /// </summary>
        [JsonProperty("content_id")]
        public string ContentId { get; set; }

        /// <summary>
        /// 内容封面
        /// </summary>
        [JsonProperty("cover")]
        public string Cover { get; set; }

        /// <summary>
        /// 内容详情H5链接
        /// </summary>
        [JsonProperty("detail_url")]
        public string DetailUrl { get; set; }

        /// <summary>
        /// 图片链接列表
        /// </summary>
        [JsonProperty("image_list")]
        public List<string> ImageList { get; set; }

        /// <summary>
        /// 内容修改时间
        /// </summary>
        [JsonProperty("modified_date")]
        public long ModifiedDate { get; set; }

        /// <summary>
        /// poi列表
        /// </summary>
        [JsonProperty("poi_list")]
        public List<ContentPoiData> PoiList { get; set; }

        /// <summary>
        /// 内容发布时间
        /// </summary>
        [JsonProperty("publish_date")]
        public long PublishDate { get; set; }

        /// <summary>
        /// 标签列表
        /// </summary>
        [JsonProperty("tag_list")]
        public List<string> TagList { get; set; }

        /// <summary>
        /// 内容标题
        /// </summary>
        [JsonProperty("title")]
        public string Title { get; set; }
    }
}
