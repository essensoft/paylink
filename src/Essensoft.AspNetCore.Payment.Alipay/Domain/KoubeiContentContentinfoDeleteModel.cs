using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KoubeiContentContentinfoDeleteModel Data Structure.
    /// </summary>
    public class KoubeiContentContentinfoDeleteModel : AlipayObject
    {
        /// <summary>
        /// 口碑端内容唯一id，必填
        /// </summary>
        [JsonPropertyName("content_id")]
        public string ContentId { get; set; }
    }
}
