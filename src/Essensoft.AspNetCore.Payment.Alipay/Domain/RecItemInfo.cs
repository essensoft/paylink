using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// RecItemInfo Data Structure.
    /// </summary>
    public class RecItemInfo : AlipayObject
    {
        /// <summary>
        /// 归属地区
        /// </summary>
        [JsonPropertyName("area_code")]
        public string AreaCode { get; set; }

        /// <summary>
        /// 业务分类
        /// </summary>
        [JsonPropertyName("biz_type")]
        public string BizType { get; set; }

        /// <summary>
        /// 描述信息
        /// </summary>
        [JsonPropertyName("description")]
        public string Description { get; set; }

        /// <summary>
        /// 扩展信息,JSONSTRING格式
        /// </summary>
        [JsonPropertyName("ext_info")]
        public string ExtInfo { get; set; }

        /// <summary>
        /// 图标地址
        /// </summary>
        [JsonPropertyName("icon")]
        public string Icon { get; set; }

        /// <summary>
        /// Item编码
        /// </summary>
        [JsonPropertyName("item_code")]
        public string ItemCode { get; set; }

        /// <summary>
        /// 服务ID
        /// </summary>
        [JsonPropertyName("item_id")]
        public string ItemId { get; set; }

        /// <summary>
        /// 推荐Item名称
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// 服务编码
        /// </summary>
        [JsonPropertyName("service_code")]
        public string ServiceCode { get; set; }

        /// <summary>
        /// 状态
        /// </summary>
        [JsonPropertyName("status")]
        public string Status { get; set; }

        /// <summary>
        /// Item分类
        /// </summary>
        [JsonPropertyName("type")]
        public string Type { get; set; }

        /// <summary>
        /// Item地址
        /// </summary>
        [JsonPropertyName("url")]
        public string Url { get; set; }
    }
}
