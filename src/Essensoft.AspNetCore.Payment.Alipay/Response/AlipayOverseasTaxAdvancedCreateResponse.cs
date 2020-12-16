using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayOverseasTaxAdvancedCreateResponse.
    /// </summary>
    public class AlipayOverseasTaxAdvancedCreateResponse : AlipayResponse
    {
        /// <summary>
        /// 线上预授权下单时返回，用于唤起收银台的参数，有效期15分钟。过期后无法唤起收银台，可以使用相同的out_tax_refund_no重新下单来获取新的order_str
        /// </summary>
        [JsonPropertyName("order_str")]
        public string OrderStr { get; set; }

        /// <summary>
        /// 退税机构业务流水号
        /// </summary>
        [JsonPropertyName("out_tax_refund_no")]
        public string OutTaxRefundNo { get; set; }

        /// <summary>
        /// 支付宝退税资金订单号
        /// </summary>
        [JsonPropertyName("tax_refund_no")]
        public string TaxRefundNo { get; set; }
    }
}
