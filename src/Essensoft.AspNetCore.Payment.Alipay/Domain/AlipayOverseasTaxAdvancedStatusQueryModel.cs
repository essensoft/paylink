using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayOverseasTaxAdvancedStatusQueryModel Data Structure.
    /// </summary>
    public class AlipayOverseasTaxAdvancedStatusQueryModel : AlipayObject
    {
        /// <summary>
        /// 退税机构业务流水号，唯一，只能包含字母、数字
        /// </summary>
        [JsonPropertyName("out_tax_refund_no")]
        public string OutTaxRefundNo { get; set; }
    }
}
