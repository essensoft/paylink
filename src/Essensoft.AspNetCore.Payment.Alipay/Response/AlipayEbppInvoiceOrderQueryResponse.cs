using System.Text.Json.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayEbppInvoiceOrderQueryResponse.
    /// </summary>
    public class AlipayEbppInvoiceOrderQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 根据订单号发票查询要素信息
        /// </summary>
        [JsonPropertyName("invoice_element_model")]
        public InvoiceElementModel InvoiceElementModel { get; set; }

        /// <summary>
        /// 开票申请时传入订单号（支持主单号、子单号），不限是否为支付宝体内交易单号
        /// </summary>
        [JsonPropertyName("order_no")]
        public string OrderNo { get; set; }
    }
}
