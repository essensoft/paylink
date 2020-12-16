using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayEbppInvoiceEinvpackageQueryModel Data Structure.
    /// </summary>
    public class AlipayEbppInvoiceEinvpackageQueryModel : AlipayObject
    {
        /// <summary>
        /// 加密过的uid
        /// </summary>
        [JsonPropertyName("encrypted_uid")]
        public string EncryptedUid { get; set; }

        /// <summary>
        /// 发票包id
        /// </summary>
        [JsonPropertyName("package_id")]
        public string PackageId { get; set; }
    }
}
