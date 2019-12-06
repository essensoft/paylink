using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// PropertyAuthInfo Data Structure.
    /// </summary>
    public class PropertyAuthInfo : AlipayObject
    {
        /// <summary>
        /// 小区所在区县
        /// </summary>
        [JsonPropertyName("area")]
        public string Area { get; set; }

        /// <summary>
        /// 小区所在城市
        /// </summary>
        [JsonPropertyName("city")]
        public string City { get; set; }

        /// <summary>
        /// 小区名称
        /// </summary>
        [JsonPropertyName("community")]
        public string Community { get; set; }

        /// <summary>
        /// 认证信息ID（ISV提供，作为修改、删除唯一标识）
        /// </summary>
        [JsonPropertyName("data_id")]
        public string DataId { get; set; }

        /// <summary>
        /// 小区纬度
        /// </summary>
        [JsonPropertyName("latitude")]
        public string Latitude { get; set; }

        /// <summary>
        /// 小区经度
        /// </summary>
        [JsonPropertyName("longitude")]
        public string Longitude { get; set; }

        /// <summary>
        /// 物业公司
        /// </summary>
        [JsonPropertyName("property")]
        public string Property { get; set; }

        /// <summary>
        /// 支付宝用户ID
        /// </summary>
        [JsonPropertyName("uid")]
        public string Uid { get; set; }
    }
}
