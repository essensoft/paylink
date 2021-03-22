using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// AlipayEbppInvoiceEinvpackageQueryModel Data Structure.
    /// </summary>
    public class AlipayEbppInvoiceEinvpackageQueryModel : AlipayObject
    {
        /// <summary>
        /// 加密过的uid。获取详情参见 <a href="https://opendocs.alipay.com/open/017fwh">"推"模式发票报销</a>。
        /// </summary>
        [JsonPropertyName("encrypted_uid")]
        public string EncryptedUid { get; set; }

        /// <summary>
        /// 发票包id。获取详情参见 <a href="https://opendocs.alipay.com/open/017fwh">"推"模式发票报销</a>。
        /// </summary>
        [JsonPropertyName("package_id")]
        public string PackageId { get; set; }
    }
}
