using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// SearchOrderDetailDataBaseItems Data Structure.
    /// </summary>
    public class SearchOrderDetailDataBaseItems : AlipayObject
    {
        /// <summary>
        /// 搜索可见性
        /// </summary>
        [JsonPropertyName("can_search")]
        public string CanSearch { get; set; }

        /// <summary>
        /// 描述信息
        /// </summary>
        [JsonPropertyName("desc")]
        public string Desc { get; set; }

        /// <summary>
        /// img地址
        /// </summary>
        [JsonPropertyName("img")]
        public string Img { get; set; }

        /// <summary>
        /// 关键词
        /// </summary>
        [JsonPropertyName("key_word")]
        public string KeyWord { get; set; }

        /// <summary>
        /// 应用名称
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// 基础工单详情region
        /// </summary>
        [JsonPropertyName("region")]
        public string Region { get; set; }

        /// <summary>
        /// 搜索可见性
        /// </summary>
        [JsonPropertyName("serv_can_search")]
        public string ServCanSearch { get; set; }

        /// <summary>
        /// 搜索关键词
        /// </summary>
        [JsonPropertyName("serv_search_keywords")]
        public string ServSearchKeywords { get; set; }

        /// <summary>
        /// 模板id
        /// </summary>
        [JsonPropertyName("template_id")]
        public string TemplateId { get; set; }

        /// <summary>
        /// 跳转url链接
        /// </summary>
        [JsonPropertyName("url")]
        public string Url { get; set; }
    }
}
