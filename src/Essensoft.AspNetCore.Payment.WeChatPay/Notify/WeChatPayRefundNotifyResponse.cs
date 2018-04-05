using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.WeChatPay.Notify
{
    public class WeChatPayRefundNotifyResponse : WeChatPayNotifyResponse
    {
        /// <summary>
        /// 返回状态码
        /// 此字段是通信标识，非交易标识，
        /// 交易是否成功需要查看result_code来判断
        /// </summary>
        [JsonProperty("return_code")]
        public string ReturnCode { get; set; }

        /// <summary>
        /// 返回信息，如非空，为错误原因
        /// 签名失败
        /// 参数格式校验错误
        /// </summary>
        [JsonProperty("return_msg")]
        public string ReturnMsg { get; set; }

        /// <summary>
        /// 公众账号ID
        /// </summary>
        [JsonProperty("appid")]
        public string AppId { get; set; }

        /// <summary>
        /// 商户号
        /// </summary>
        [JsonProperty("mch_id")]
        public string MchId { get; set; }

        /// <summary>
        /// 子商户公众账号ID
        /// </summary>
        [JsonProperty("sub_appid")]
        public string SubAppId { get; set; }

        /// <summary>
        /// 子商户号
        /// </summary>
        [JsonProperty("sub_mch_id")]
        public string SubMchId { get; set; }

        /// <summary>
        /// 随机字符串
        /// </summary>
        [JsonProperty("nonce_str")]
        public string NonceStr { get; set; }

        /// <summary>
        /// 加密信息
        /// </summary>
        [JsonProperty("req_info")]
        public string ReqInfo { get; set; }

        // 解密后的信息

        /// <summary>
        /// 微信订单号
        /// </summary>
        [JsonProperty("transaction_id")]
        public string TransactionId { get; set; }

        /// <summary>
        /// 商户订单号
        /// </summary>
        [JsonProperty("out_trade_no")]
        public string OutTradeNo { get; set; }

        /// <summary>
        /// 微信退款单号
        /// </summary>
        [JsonProperty("refund_id")]
        public string RefundId { get; set; }

        /// <summary>
        /// 商户退款单号
        /// </summary>
        [JsonProperty("out_refund_no")]
        public string OutRefundNo { get; set; }

        /// <summary>
        /// 订单金额
        /// </summary>
        [JsonProperty("total_fee")]
        public int TotalFee { get; set; }

        /// <summary>
        /// 应结订单金额
        /// </summary>
        [JsonProperty("settlement_total_fee")]
        public int SettlementTotalFee { get; set; }

        /// <summary>
        /// 申请退款金额
        /// </summary>
        [JsonProperty("refund_fee")]
        public int RefundFee { get; set; }

        /// <summary>
        /// 退款金额
        /// </summary>
        [JsonProperty("settlement_refund_fee")]
        public int SettlementRefundFee { get; set; }

        /// <summary>
        /// 退款状态
        /// </summary>
        [JsonProperty("refund_status")]
        public string RefundStatus { get; set; }

        /// <summary>
        /// 退款成功时间
        /// </summary>
        [JsonProperty("success_time")]
        public string SuccessTime { get; set; }

        /// <summary>
        /// 退款入账账户
        /// </summary>
        [JsonProperty("refund_recv_accout")]
        public string RefundRecvAccout { get; set; }

        /// <summary>
        /// 退款资金来源
        /// </summary>
        [JsonProperty("refund_account")]
        public string RefundAccount { get; set; }

        /// <summary>
        /// 退款发起来源
        /// </summary>
        [JsonProperty("refund_request_source")]
        public string RefundRequestSource { get; set; }
    }
}
