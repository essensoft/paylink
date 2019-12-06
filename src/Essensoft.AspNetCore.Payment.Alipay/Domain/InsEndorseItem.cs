using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// InsEndorseItem Data Structure.
    /// </summary>
    public class InsEndorseItem : AlipayObject
    {
        /// <summary>
        /// 批单项新值
        /// </summary>
        [JsonPropertyName("new_value")]
        public string NewValue { get; set; }

        /// <summary>
        /// 批单项旧值
        /// </summary>
        [JsonPropertyName("old_value")]
        public string OldValue { get; set; }

        /// <summary>
        /// 批单类型;303:保单改期;311:批改保单标的
        /// </summary>
        [JsonPropertyName("type")]
        public long Type { get; set; }
    }
}
