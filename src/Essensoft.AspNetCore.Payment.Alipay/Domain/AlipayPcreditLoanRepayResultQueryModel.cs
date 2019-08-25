using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayPcreditLoanRepayResultQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayPcreditLoanRepayResultQueryModel : AlipayObject
    {
        /// <summary>
        /// 还款申请业务标准外部订单号，即商户端进行还款申请提交时所传入的商户端自己的订单号，必须保证与外部业务单号二者不能同时为空。
        /// </summary>
        [JsonProperty("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 代表了一次请求，作为业务幂等性控制
        /// </summary>
        [JsonProperty("out_request_no")]
        public string OutRequestNo { get; set; }

        /// <summary>
        /// 还款受理单号，即还款申请提交接口返回的还款受理单号，必须保证与外部业务单号二者不能同时为空。
        /// </summary>
        [JsonProperty("repay_receipt_no")]
        public string RepayReceiptNo { get; set; }
    }
}
