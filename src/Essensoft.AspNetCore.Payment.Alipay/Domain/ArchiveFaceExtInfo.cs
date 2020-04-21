using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// ArchiveFaceExtInfo Data Structure.
    /// </summary>
    public class ArchiveFaceExtInfo : AlipayObject
    {
        /// <summary>
        /// 证件提供者的支付宝uid
        /// </summary>
        [JsonPropertyName("provider_uid")]
        public string ProviderUid { get; set; }
    }
}
