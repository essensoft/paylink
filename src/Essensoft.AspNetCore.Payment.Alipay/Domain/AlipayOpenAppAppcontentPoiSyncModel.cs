using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayOpenAppAppcontentPoiSyncModel Data Structure.
    /// </summary>
    public class AlipayOpenAppAppcontentPoiSyncModel : AlipayObject
    {
        /// <summary>
        /// 具体地址的描述
        /// </summary>
        [JsonPropertyName("address")]
        public string Address { get; set; }

        /// <summary>
        /// 支付宝端内小程序地址
        /// </summary>
        [JsonPropertyName("alipay_url")]
        public string AlipayUrl { get; set; }

        /// <summary>
        /// 高德标准的POI ID
        /// </summary>
        [JsonPropertyName("amap_poi_id")]
        public string AmapPoiId { get; set; }

        /// <summary>
        /// 应用内容属性
        /// </summary>
        [JsonPropertyName("attributes")]
        public List<Attribute> Attributes { get; set; }

        /// <summary>
        /// 业务来源，如“社区生活”。 商户申请/调试接口过程中，由支付宝侧业务接口人分配确认。
        /// </summary>
        [JsonPropertyName("biz_source")]
        public string BizSource { get; set; }

        /// <summary>
        /// 业务唯一ID，APPID视角下唯一。支付宝侧会通过biz_source + appId + biz_unique_id作为联合主键，进行相应的创建或者更新操作。
        /// </summary>
        [JsonPropertyName("biz_unique_id")]
        public string BizUniqueId { get; set; }

        /// <summary>
        /// 联系人名称
        /// </summary>
        [JsonPropertyName("contact_name")]
        public string ContactName { get; set; }

        /// <summary>
        /// 联系电话
        /// </summary>
        [JsonPropertyName("contact_tele")]
        public string ContactTele { get; set; }

        /// <summary>
        /// 维度
        /// </summary>
        [JsonPropertyName("latitude")]
        public string Latitude { get; set; }

        /// <summary>
        /// poi的logo/头像
        /// </summary>
        [JsonPropertyName("logo")]
        public string Logo { get; set; }

        /// <summary>
        /// 经度
        /// </summary>
        [JsonPropertyName("longitude")]
        public string Longitude { get; set; }

        /// <summary>
        /// 具体的地点名称
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// 逗号分隔的图片数组，最多5个
        /// </summary>
        [JsonPropertyName("photos")]
        public List<string> Photos { get; set; }
    }
}
