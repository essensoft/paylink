using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// SearchOrderDetailDataServiceItems Data Structure.
    /// </summary>
    public class SearchOrderDetailDataServiceItems : AlipayObject
    {
        /// <summary>
        /// 服务工单详情area_codes
        /// </summary>
        [JsonPropertyName("area_codes")]
        public string AreaCodes { get; set; }

        /// <summary>
        /// carrier_code
        /// </summary>
        [JsonPropertyName("carrier_code")]
        public string CarrierCode { get; set; }

        /// <summary>
        /// 服务工单数据carrier_list
        /// </summary>
        [JsonPropertyName("carrier_list")]
        public string CarrierList { get; set; }

        /// <summary>
        /// 服务工单category_attribute_value
        /// </summary>
        [JsonPropertyName("category_attribute_value")]
        public string CategoryAttributeValue { get; set; }

        /// <summary>
        /// 类目id
        /// </summary>
        [JsonPropertyName("category_code")]
        public string CategoryCode { get; set; }

        /// <summary>
        /// 类目id
        /// </summary>
        [JsonPropertyName("category_ids")]
        public string CategoryIds { get; set; }

        /// <summary>
        /// 渠道类型
        /// </summary>
        [JsonPropertyName("channel_type")]
        public string ChannelType { get; set; }

        /// <summary>
        /// 描述
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
        /// 关键词列表
        /// </summary>
        [JsonPropertyName("key_word_list")]
        public string KeyWordList { get; set; }

        /// <summary>
        /// logo图片地址
        /// </summary>
        [JsonPropertyName("logo")]
        public string Logo { get; set; }

        /// <summary>
        /// 应用名称
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// 服务编码
        /// </summary>
        [JsonPropertyName("parent_service_code")]
        public string ParentServiceCode { get; set; }

        /// <summary>
        /// 服务工单详情region
        /// </summary>
        [JsonPropertyName("region")]
        public string Region { get; set; }

        /// <summary>
        /// serv_search_catalogs
        /// </summary>
        [JsonPropertyName("serv_search_catalogs")]
        public string ServSearchCatalogs { get; set; }

        /// <summary>
        /// 关键词
        /// </summary>
        [JsonPropertyName("serv_search_keywords")]
        public string ServSearchKeywords { get; set; }

        /// <summary>
        /// 2020112321000021082348
        /// </summary>
        [JsonPropertyName("service_code")]
        public string ServiceCode { get; set; }

        /// <summary>
        /// 服务名称
        /// </summary>
        [JsonPropertyName("service_name")]
        public string ServiceName { get; set; }

        /// <summary>
        /// 服务结束时间
        /// </summary>
        [JsonPropertyName("service_time_end")]
        public string ServiceTimeEnd { get; set; }

        /// <summary>
        /// 服务开始时间
        /// </summary>
        [JsonPropertyName("service_time_start")]
        public string ServiceTimeStart { get; set; }

        /// <summary>
        /// 服务短描述
        /// </summary>
        [JsonPropertyName("short_desc")]
        public string ShortDesc { get; set; }

        /// <summary>
        /// 应用标识
        /// </summary>
        [JsonPropertyName("spec_code")]
        public string SpecCode { get; set; }

        /// <summary>
        /// 模板id
        /// </summary>
        [JsonPropertyName("template_id")]
        public string TemplateId { get; set; }
    }
}
