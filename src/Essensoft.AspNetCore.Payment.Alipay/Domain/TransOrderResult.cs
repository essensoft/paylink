using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// TransOrderResult Data Structure.
    /// </summary>
    [Serializable]
    public class TransOrderResult : AlipayObject
    {
        /// <summary>
        /// 转账失败时的错误码描述。
        /// </summary>
        [JsonProperty("error_code")]
        public string ErrorCode { get; set; }

        /// <summary>
        /// 转账失败时的错误原因描述
        /// </summary>
        [JsonProperty("fail_reason")]
        public string FailReason { get; set; }

        /// <summary>
        /// 该笔转账在支付宝系统内部的单据ID。
        /// </summary>
        [JsonProperty("order_id")]
        public string OrderId { get; set; }

        /// <summary>
        /// 商户订单号
        /// </summary>
        [JsonProperty("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 转账单据状态。   SUCCESS：转账成功（对转账到银行卡的单据, 同一笔单据多次查询有可能从成功变成退票状态）；   FAIL：转账失败（具体失败原因请参见error_code以及fail_reason返回值）；   WAIT_PAY：转账订单等待支付（只有alipay.fund.trans.app.pay接口的单据有此状态）；   DEALING：转账到银行卡处理中；   REFUND：退票 收款方是银行卡时会有次状态, 具体退票原因请参见fail_reason返回值）；          CLOSED：订单超时关闭（只有alipay.fund.trans.app.pay接口的单据有此状态）    APP转账涉及的状态： WAIT_PAY SUCCESS CLOSED  转账到卡涉及的状态：DEALING FAIL SUCCESS REFUND   转账到支付宝账户涉及的状态：FAIL SUCCESS
        /// </summary>
        [JsonProperty("status")]
        public string Status { get; set; }
    }
}
