using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// RemoveTagRequest Data Structure.
    /// </summary>
    public class RemoveTagRequest : AlipayObject
    {
        /// <summary>
        /// biz_id，唯一，业务id，用于业务请求的幂等标志
        /// </summary>
        [JsonPropertyName("biz_id")]
        public string BizId { get; set; }

        /// <summary>
        /// 去标类型，PID或SMID
        /// </summary>
        [JsonPropertyName("type")]
        public string Type { get; set; }

        /// <summary>
        /// pid或smid的值
        /// </summary>
        [JsonPropertyName("value")]
        public string Value { get; set; }
    }
}
