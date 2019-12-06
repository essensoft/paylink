using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipaySocialBaseChatGinfoQueryModel Data Structure.
    /// </summary>
    public class AlipaySocialBaseChatGinfoQueryModel : AlipayObject
    {
        /// <summary>
        /// 群id
        /// </summary>
        [JsonPropertyName("group_id")]
        public string GroupId { get; set; }
    }
}
