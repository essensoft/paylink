using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayInsSceneApplicationQueryResponse.
    /// </summary>
    public class AlipayInsSceneApplicationQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 投保订单号
        /// </summary>
        [JsonPropertyName("application_no")]
        public string ApplicationNo { get; set; }

        /// <summary>
        /// 投保单状态;此状态用于判断投保流程的推进过程.INIT: 初始,UNDERWROTE:已核保, DECLINED:已拒保,CLOSED:已关闭, PAID:已付款,REFUND:已退款,ISSUED:已出单
        /// </summary>
        [JsonPropertyName("application_status")]
        public string ApplicationStatus { get; set; }

        /// <summary>
        /// 交易操作流水号;用于跳支付宝收银台付款
        /// </summary>
        [JsonPropertyName("operation_id")]
        public string OperationId { get; set; }

        /// <summary>
        /// 商户生成的外部投保业务号
        /// </summary>
        [JsonPropertyName("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 保单;当投保单状态不是已出单,保单为空
        /// </summary>
        [JsonPropertyName("policys")]
        public List<InsPolicy> Policys { get; set; }

        /// <summary>
        /// 支付交易订单号;用于跳支付宝收银台付款
        /// </summary>
        [JsonPropertyName("trade_no")]
        public string TradeNo { get; set; }
    }
}
