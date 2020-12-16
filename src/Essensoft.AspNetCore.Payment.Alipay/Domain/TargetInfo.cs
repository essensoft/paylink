using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// TargetInfo Data Structure.
    /// </summary>
    public class TargetInfo : AlipayObject
    {
        /// <summary>
        /// 应用id，例如小程序id
        /// </summary>
        [JsonPropertyName("target_id")]
        public string TargetId { get; set; }

        /// <summary>
        /// 应用类型 小程序传入：APPID 生活号传入：PUBLICID
        /// </summary>
        [JsonPropertyName("target_type")]
        public string TargetType { get; set; }
    }
}
