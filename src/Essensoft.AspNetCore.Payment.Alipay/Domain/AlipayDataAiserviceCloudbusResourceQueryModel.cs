using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayDataAiserviceCloudbusResourceQueryModel Data Structure.
    /// </summary>
    public class AlipayDataAiserviceCloudbusResourceQueryModel : AlipayObject
    {
        /// <summary>
        /// 按类型查找， 空默认查询所有
        /// </summary>
        [JsonPropertyName("type")]
        public long Type { get; set; }
    }
}
