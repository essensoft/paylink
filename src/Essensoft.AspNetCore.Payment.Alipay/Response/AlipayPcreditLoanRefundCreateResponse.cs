using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayPcreditLoanRefundCreateResponse.
    /// </summary>
    public class AlipayPcreditLoanRefundCreateResponse : AlipayResponse
    {
        /// <summary>
        /// 受理的还款申请单号
        /// </summary>
        [JsonProperty("loan_repay_no")]
        [XmlElement("loan_repay_no")]
        public string LoanRepayNo { get; set; }
    }
}
