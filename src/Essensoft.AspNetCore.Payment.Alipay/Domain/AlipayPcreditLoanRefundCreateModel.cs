using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayPcreditLoanRefundCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayPcreditLoanRefundCreateModel : AlipayObject
    {
        /// <summary>
        /// 蚂蚁借呗贷款申请编号
        /// </summary>
        [JsonProperty("loan_apply_no")]
        [XmlElement("loan_apply_no")]
        public string LoanApplyNo { get; set; }

        /// <summary>
        /// 商户还款订单号
        /// </summary>
        [JsonProperty("out_biz_no")]
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 商户还款金额
        /// </summary>
        [JsonProperty("repay_amt")]
        [XmlElement("repay_amt")]
        public string RepayAmt { get; set; }

        /// <summary>
        /// 请求流水号，用于控制幂等
        /// </summary>
        [JsonProperty("req_id")]
        [XmlElement("req_id")]
        public string ReqId { get; set; }
    }
}
