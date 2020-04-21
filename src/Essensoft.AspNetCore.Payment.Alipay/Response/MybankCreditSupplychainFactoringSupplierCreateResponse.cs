using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
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
