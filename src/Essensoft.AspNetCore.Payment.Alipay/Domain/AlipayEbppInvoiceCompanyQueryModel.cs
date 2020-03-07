using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayEbppInvoiceCompanyQueryModel Data Structure.
    /// </summary>
    public class AlipayEbppInvoiceCompanyQueryModel : AlipayObject
    {
        /// <summary>
        /// 纳税人识别号。register_id与payee_register_no不能同时为空
        /// </summary>
        [JsonPropertyName("payee_register_no")]
        public string PayeeRegisterNo { get; set; }

        /// <summary>
        /// 入驻工单ID. register_id与payee_register_no不能同时为空
        /// </summary>
        [JsonPropertyName("register_id")]
        public string RegisterId { get; set; }
    }
}
