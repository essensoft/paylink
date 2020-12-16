using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayOverseasTransferInstitutionpaymentQueryResponse.
    /// </summary>
    public class AlipayOverseasTransferInstitutionpaymentQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 透传保留字段，json map格式
        /// </summary>
        [JsonPropertyName("pass_through_info")]
        public string PassThroughInfo { get; set; }

        /// <summary>
        /// 学校缴费项列表List<PaymemtDetail>
        /// </summary>
        [JsonPropertyName("payment_details")]
        public List<string> PaymentDetails { get; set; }
    }
}
