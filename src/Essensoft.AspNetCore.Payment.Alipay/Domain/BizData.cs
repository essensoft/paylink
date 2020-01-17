using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// BizData Data Structure.
    /// </summary>
    public class BizData : AlipayObject
    {
        /// <summary>
        /// 素材内容数据
        /// </summary>
        [JsonPropertyName("data")]
        public string Data { get; set; }

        /// <summary>
        /// 业务数据唯一标识
        /// </summary>
        [JsonPropertyName("key")]
        public string Key { get; set; }
    }
}
