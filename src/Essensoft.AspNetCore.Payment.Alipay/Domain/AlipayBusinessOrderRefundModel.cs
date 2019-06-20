using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayBusinessOrderRefundModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayBusinessOrderRefundModel : AlipayObject
    {
        /// <summary>
        /// 订单退款环境信息
        /// </summary>
        [JsonProperty("env_info")]
        public EnvInfo EnvInfo { get; set; }

        /// <summary>
        /// 支付宝订单号
        /// </summary>
        [JsonProperty("order_no")]
        public string OrderNo { get; set; }

        /// <summary>
        /// 退款支付工具列表
        /// </summary>
        [JsonProperty("refund_paytool_list")]
        public List<PaytoolRefundRequestDetail> RefundPaytoolList { get; set; }

        /// <summary>
        /// 退款原因
        /// </summary>
        [JsonProperty("refund_reason")]
        public string RefundReason { get; set; }

        /// <summary>
        /// 退款请求号。若退款请求号不为空，则必需传入refund_paytools_list。  若不传入退款请求号，同时refund_paytools_list为空，则认为是全额退款。
        /// </summary>
        [JsonProperty("refund_request_no")]
        public string RefundRequestNo { get; set; }
    }
}
