using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayFundTransCommonQueryResponse.
    /// </summary>
    public class AlipayFundTransCommonQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 查询到的订单状态为FAIL失败或REFUND退票时，返回错误代码
        /// </summary>
        [JsonProperty("error_code")]
        public string ErrorCode { get; set; }

        /// <summary>
        /// 查询到的订单状态为FAIL失败或REFUND退票时，返回具体的原因。
        /// </summary>
        [JsonProperty("fail_reason")]
        public string FailReason { get; set; }

        /// <summary>
        /// 支付宝转账单据号，查询失败不返回。
        /// </summary>
        [JsonProperty("order_id")]
        public string OrderId { get; set; }

        /// <summary>
        /// 商户订单号
        /// </summary>
        [JsonProperty("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 商户回传参数
        /// </summary>
        [JsonProperty("passback_params")]
        public string PassbackParams { get; set; }

        /// <summary>
        /// 转账单据状态。可能出现的状态如下：  SUCCESS：转账成功；  WAIT_PAY：等待支付；         CLOSED：订单超时关闭  alipay.fund.trans.app.pay涉及的状态： WAIT_PAY、SUCCESS、CLOSED alipay.fund.trans.uni.transfer、alipay.fund.trans.refund涉及的状态：SUCCESS
        /// </summary>
        [JsonProperty("status")]
        public string Status { get; set; }
    }
}
