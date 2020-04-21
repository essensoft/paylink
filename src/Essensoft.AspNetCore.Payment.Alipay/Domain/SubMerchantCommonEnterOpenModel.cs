using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// SubMerchantCommonEnterOpenModel Data Structure.
    /// </summary>
    public class SubMerchantCommonEnterOpenModel : AlipayObject
    {
        /// <summary>
        /// 扩展字段，为json字符串格式；入驻支付即开票的产品，需要传入用户白名单的时候，由此字段传入；支付即开票商户配置维度，如果不传默认为SMID_MOD，目前仅支持SMID_MODE和PID_MODE
        /// </summary>
        [JsonPropertyName("extend_fields")]
        public string ExtendFields { get; set; }

        /// <summary>
        /// 商户门店入驻的产品码,STANDARD_INVOICE:扫码开票，INVOICE_RETURN:企业自建-发票回传，INVOICE_EXPENSE:发票报销，PAYMENT_OPEN:支付即开票，PAY_FEE_OPEN:缴费后开票。
        /// </summary>
        [JsonPropertyName("product_code")]
        public string ProductCode { get; set; }

        /// <summary>
        /// 商户门店所属的服务方简称。
        /// </summary>
        [JsonPropertyName("s_short_name")]
        public string SShortName { get; set; }
    }
}
