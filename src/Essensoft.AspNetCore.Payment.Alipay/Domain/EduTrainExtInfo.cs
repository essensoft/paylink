using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// EduTrainExtInfo Data Structure.
    /// </summary>
    public class EduTrainExtInfo : AlipayObject
    {
        /// <summary>
        /// 参数的名字
        /// </summary>
        [JsonPropertyName("key")]
        public string Key { get; set; }

        /// <summary>
        /// 参数的值
        /// </summary>
        [JsonPropertyName("value")]
        public string Value { get; set; }
    }
}
