using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// NearMallBo Data Structure.
    /// </summary>
    public class NearMallBo : AlipayObject
    {
        /// <summary>
        /// json字符串表示额外信息
        /// </summary>
        [JsonPropertyName("attribute")]
        public string Attribute { get; set; }

        /// <summary>
        /// 距离
        /// </summary>
        [JsonPropertyName("distance")]
        public string Distance { get; set; }

        /// <summary>
        /// 经度
        /// </summary>
        [JsonPropertyName("latitude")]
        public string Latitude { get; set; }

        /// <summary>
        /// 纬度
        /// </summary>
        [JsonPropertyName("longitude")]
        public string Longitude { get; set; }

        /// <summary>
        /// 商圈id
        /// </summary>
        [JsonPropertyName("mall_id")]
        public string MallId { get; set; }

        /// <summary>
        /// 商圈图片
        /// </summary>
        [JsonPropertyName("mall_logo")]
        public string MallLogo { get; set; }

        /// <summary>
        /// 商圈名字
        /// </summary>
        [JsonPropertyName("mall_name")]
        public string MallName { get; set; }
    }
}
