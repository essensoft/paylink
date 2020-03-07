using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayEbppInvoiceRegisterCreateResponse.
    /// </summary>
    public class AlipayEbppInvoiceRegisterCreateResponse : AlipayResponse
    {
        /// <summary>
        /// 入驻工单ID，发票中台生成
        /// </summary>
        [JsonPropertyName("register_id")]
        public string RegisterId { get; set; }
    }
}
