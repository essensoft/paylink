using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// ServiceInfo Data Structure.
    /// </summary>
    public class ServiceInfo : AlipayObject
    {
        /// <summary>
        /// 支付宝端内地址
        /// </summary>
        [JsonPropertyName("alipay_url")]
        public string AlipayUrl { get; set; }

        /// <summary>
        /// 服务审核状态
        /// </summary>
        [JsonPropertyName("audit_status")]
        public string AuditStatus { get; set; }

        /// <summary>
        /// 业务来源
        /// </summary>
        [JsonPropertyName("biz_source")]
        public string BizSource { get; set; }

        /// <summary>
        /// 服务简介
        /// </summary>
        [JsonPropertyName("detail_desc")]
        public string DetailDesc { get; set; }

        /// <summary>
        /// 服务颗粒度
        /// </summary>
        [JsonPropertyName("granularity_type")]
        public string GranularityType { get; set; }

        /// <summary>
        /// 服务关键词
        /// </summary>
        [JsonPropertyName("key_words")]
        public List<string> KeyWords { get; set; }

        /// <summary>
        /// logo的CDN地址
        /// </summary>
        [JsonPropertyName("logo")]
        public string Logo { get; set; }

        /// <summary>
        /// 服务主状态
        /// </summary>
        [JsonPropertyName("major_status")]
        public string MajorStatus { get; set; }

        /// <summary>
        /// 服务归属的小程序ID
        /// </summary>
        [JsonPropertyName("ref_app_id")]
        public string RefAppId { get; set; }

        /// <summary>
        /// 服务归属的父服务编码
        /// </summary>
        [JsonPropertyName("ref_service_code")]
        public string RefServiceCode { get; set; }

        /// <summary>
        /// 服务编码
        /// </summary>
        [JsonPropertyName("service_code")]
        public string ServiceCode { get; set; }

        /// <summary>
        /// 服务名称
        /// </summary>
        [JsonPropertyName("service_name")]
        public string ServiceName { get; set; }

        /// <summary>
        /// 服务简单描述
        /// </summary>
        [JsonPropertyName("simple_desc")]
        public string SimpleDesc { get; set; }

        /// <summary>
        /// 服务提供方ID
        /// </summary>
        [JsonPropertyName("supplier_id")]
        public string SupplierId { get; set; }

        /// <summary>
        /// 服务提供方类型
        /// </summary>
        [JsonPropertyName("supplier_type")]
        public string SupplierType { get; set; }
    }
}
