using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// PaytoolCancelRequestDetail Data Structure.
    /// </summary>
    [Serializable]
    public class PaytoolCancelRequestDetail : AlipayObject
    {
        /// <summary>
        /// 支付宝支付工具单据号，与商户支付工具单据号不能同时为空。
        /// </summary>
        [JsonProperty("paytool_bill_no")]
        public string PaytoolBillNo { get; set; }

        /// <summary>
        /// 商户外部支付工具单据号，与支付宝支付工具单据号不能同时为空
        /// </summary>
        [JsonProperty("paytool_request_no")]
        public string PaytoolRequestNo { get; set; }
    }
}
