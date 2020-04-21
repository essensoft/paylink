using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayOpenAppServiceSyncModel Data Structure.
    /// </summary>
    public class AlipayOpenAppServiceSyncModel : AlipayObject
    {
        /// <summary>
        /// 服务地址
        /// </summary>
        [JsonPropertyName("address")]
        public List<ServiceAddressSimpleVO> Address { get; set; }

        /// <summary>
        /// 服务属性
        /// </summary>
        [JsonPropertyName("attributes")]
        public ServiceAttributeSimpleVO Attributes { get; set; }

        /// <summary>
        /// 外部提供的能够标示这个服务的唯一id，如果spec+biz_id在我们库里面存在，我们会做服务的更新操作
        /// </summary>
        [JsonPropertyName("biz_id")]
        public string BizId { get; set; }

        /// <summary>
        /// 服务所属类目id
        /// </summary>
        [JsonPropertyName("category_id")]
        public string CategoryId { get; set; }

        /// <summary>
        /// 时间戳，平台会基于时间戳做并发控制
        /// </summary>
        [JsonPropertyName("date_timestamp")]
        public long DateTimestamp { get; set; }

        /// <summary>
        /// 服务粒度
        /// </summary>
        [JsonPropertyName("granularity_type")]
        public string GranularityType { get; set; }

        /// <summary>
        /// 服务的logo图片
        /// </summary>
        [JsonPropertyName("logo")]
        public string Logo { get; set; }

        /// <summary>
        /// 服务区域
        /// </summary>
        [JsonPropertyName("region")]
        public List<ServiceRegionSimpleVO> Region { get; set; }

        /// <summary>
        /// 同步服务所属的小程序appId
        /// </summary>
        [JsonPropertyName("service_app_id")]
        public string ServiceAppId { get; set; }

        /// <summary>
        /// 服务联系人
        /// </summary>
        [JsonPropertyName("service_contact")]
        public List<ServiceContactSimpleVO> ServiceContact { get; set; }

        /// <summary>
        /// 服务名称
        /// </summary>
        [JsonPropertyName("service_name")]
        public string ServiceName { get; set; }

        /// <summary>
        /// 服务描述
        /// </summary>
        [JsonPropertyName("simple_desc")]
        public string SimpleDesc { get; set; }

        /// <summary>
        /// 服务规格，平台定义，接入时跟平台申请
        /// </summary>
        [JsonPropertyName("spec_code")]
        public string SpecCode { get; set; }

        /// <summary>
        /// 服务的url
        /// </summary>
        [JsonPropertyName("url")]
        public string Url { get; set; }
    }
}
