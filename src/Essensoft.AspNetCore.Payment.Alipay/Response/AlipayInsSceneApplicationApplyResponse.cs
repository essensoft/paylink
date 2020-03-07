using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayInsSceneApplicationApplyResponse.
    /// </summary>
    public class AlipayInsSceneApplicationApplyResponse : AlipayResponse
    {
        /// <summary>
        /// 投保单号
        /// </summary>
        [JsonPropertyName("application_no")]
        public string ApplicationNo { get; set; }

        /// <summary>
        /// 交易操作流水号;收银台付款需要
        /// </summary>
        [JsonPropertyName("operation_id")]
        public string OperationId { get; set; }

        /// <summary>
        /// 商户生成的外部投保业务号,必须保证唯一
        /// </summary>
        [JsonPropertyName("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 保单详情地址
        /// </summary>
        [JsonPropertyName("policy_detail_url_4_mobile")]
        public string PolicyDetailUrl4Mobile { get; set; }

        /// <summary>
        /// 保单详情地址
        /// </summary>
        [JsonPropertyName("policy_detail_url_4_pc")]
        public string PolicyDetailUrl4Pc { get; set; }

        /// <summary>
        /// 保单号,同步创建保单的会有，异步创建保单的不返回
        /// </summary>
        [JsonPropertyName("policy_no")]
        public string PolicyNo { get; set; }

        /// <summary>
        /// 支付交易订单号,收银台付款需要
        /// </summary>
        [JsonPropertyName("trade_no")]
        public string TradeNo { get; set; }

        /// <summary>
        /// 交易类型，区分受托和担保交易
        /// </summary>
        [JsonPropertyName("trade_type")]
        public string TradeType { get; set; }

        /// <summary>
        /// 核保失败原因
        /// </summary>
        [JsonPropertyName("underwrite_reject_reason")]
        public string UnderwriteRejectReason { get; set; }
    }
}
