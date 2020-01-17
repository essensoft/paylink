using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayEbppInvoiceMerchantEnterstatusQueryModel Data Structure.
    /// </summary>
    public class AlipayEbppInvoiceMerchantEnterstatusQueryModel : AlipayObject
    {
        /// <summary>
        /// 商户品牌简称，只能由大写字母、下划线、数字组成，且必须以大写字母开头。
        /// </summary>
        [JsonPropertyName("m_short_name")]
        public string MShortName { get; set; }

        /// <summary>
        /// 工单流水号（如果不填则默认查询最近一条工单）
        /// </summary>
        [JsonPropertyName("process_id")]
        public string ProcessId { get; set; }

        /// <summary>
        /// 商户门店入驻的产品码,STANDARD_INVOICE:扫码开票，INVOICE_RETURN:企业自建-发票回传，INVOICE_EXPENSE:发票报销，PAYMENT_OPEN:支付即开票，PAY_FEE_OPEN:缴费后开票。
        /// </summary>
        [JsonPropertyName("product_code")]
        public string ProductCode { get; set; }
    }
}
