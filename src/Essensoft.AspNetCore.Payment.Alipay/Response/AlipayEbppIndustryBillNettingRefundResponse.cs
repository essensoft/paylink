using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayEbppIndustryBillNettingRefundResponse.
    /// </summary>
    public class AlipayEbppIndustryBillNettingRefundResponse : AlipayResponse
    {
        /// <summary>
        /// 回传支付宝流水号。
        /// </summary>
        [JsonPropertyName("alipay_bill_no")]
        public string AlipayBillNo { get; set; }

        /// <summary>
        /// 扩展字段，一系列键值对属性列表，示例只是个形式，具体的Key-Value需要根据具体业务另行约定。  无特别约定时，此字段不必传。
        /// </summary>
        [JsonPropertyName("industry_extend_field_list")]
        public List<IndustryExtendField> IndustryExtendFieldList { get; set; }
    }
}
