using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// AlipayCommerceIotSupplierAssetCreateResponse.
    /// </summary>
    public class AlipayCommerceIotSupplierAssetCreateResponse : AlipayResponse
    {
        /// <summary>
        /// 记录id
        /// </summary>
        [JsonPropertyName("id")]
        public long Id { get; set; }
    }
}
