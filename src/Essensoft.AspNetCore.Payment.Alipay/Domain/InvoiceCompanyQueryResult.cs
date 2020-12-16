using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// InvoiceCompanyQueryResult Data Structure.
    /// </summary>
    public class InvoiceCompanyQueryResult : AlipayObject
    {
        /// <summary>
        /// 发票限额信息
        /// </summary>
        [JsonPropertyName("amount_limit_dto_list")]
        public List<InvoiceAmountLimitDTO> AmountLimitDtoList { get; set; }

        /// <summary>
        /// 企业税务信息
        /// </summary>
        [JsonPropertyName("invoice_company_dto")]
        public InvoiceCompanyDTO InvoiceCompanyDto { get; set; }

        /// <summary>
        /// 税号已开通产品信息
        /// </summary>
        [JsonPropertyName("invoice_open_product_dto_list")]
        public List<InvoiceOpenProductDTO> InvoiceOpenProductDtoList { get; set; }

        /// <summary>
        /// 入驻工单ID
        /// </summary>
        [JsonPropertyName("register_id")]
        public string RegisterId { get; set; }

        /// <summary>
        /// 入驻工单状态
        /// </summary>
        [JsonPropertyName("register_status")]
        public long RegisterStatus { get; set; }
    }
}
