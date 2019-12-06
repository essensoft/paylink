using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// FliggyPoiInfo Data Structure.
    /// </summary>
    public class FliggyPoiInfo : AlipayObject
    {
        /// <summary>
        /// 业务code标识poi同步结果
        /// </summary>
        [JsonPropertyName("biz_code")]
        public string BizCode { get; set; }

        /// <summary>
        /// 飞猪poi同步消息,失败时为失败原因
        /// </summary>
        [JsonPropertyName("msg")]
        public string Msg { get; set; }

        /// <summary>
        /// 1. 首次poi同步成功则必须返回poiId，失败则需返回结果为失败，及错误原因； 2 后续poi同步成功/失败，均需返回。
        /// </summary>
        [JsonPropertyName("poi_id")]
        public string PoiId { get; set; }

        /// <summary>
        /// 本次同步poi的结果，成功或失败，成功则必须返回poi_id。
        /// </summary>
        [JsonPropertyName("success")]
        public bool Success { get; set; }
    }
}
