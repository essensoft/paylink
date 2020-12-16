using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayOverseasTaxAdvancedRefundModel Data Structure.
    /// </summary>
    public class AlipayOverseasTaxAdvancedRefundModel : AlipayObject
    {
        /// <summary>
        /// 支付宝退税资金订单号
        /// </summary>
        [JsonPropertyName("tax_refund_no")]
        public string TaxRefundNo { get; set; }
    }
}
