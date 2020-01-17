using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// PublicMsgKeyword Data Structure.
    /// </summary>
    public class PublicMsgKeyword : AlipayObject
    {
        /// <summary>
        /// 模板关键字名称
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }
    }
}
