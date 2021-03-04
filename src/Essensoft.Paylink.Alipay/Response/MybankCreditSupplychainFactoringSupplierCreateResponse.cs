using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// MybankCreditSupplychainFactoringSupplierCreateResponse.
    /// </summary>
    public class MybankCreditSupplychainFactoringSupplierCreateResponse : AlipayResponse
    {
        /// <summary>
        /// supplierNo : 供应商编号
        /// </summary>
        [JsonPropertyName("supplier_no")]
        public string SupplierNo { get; set; }
    }
}
