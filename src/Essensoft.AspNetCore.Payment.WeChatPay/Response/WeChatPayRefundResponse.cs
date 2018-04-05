using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.WeChatPay.Response
{
    public class WeChatPayRefundResponse : WeChatPayResponse
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
        /// 业务结果
        /// </summary>
        [JsonProperty("result_code")]
        public string ResultCode { get; set; }

        /// <summary>
        /// 错误代码
        /// </summary>
        [JsonProperty("err_code")]
        public string ErrCode { get; set; }

        /// <summary>
        /// 错误描述	
        /// </summary>
        [JsonProperty("err_code_des")]
        public string ErrCodeDes { get; set; }

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
        /// 签名
        /// </summary>
        [JsonProperty("sign")]
        public string Sign { get; set; }

        /// <summary>
        /// 微信支付订单号	
        /// </summary>
        [JsonProperty("transaction_id")]
        public string TransactionId { get; set; }

        /// <summary>
        /// 商户订单号	
        /// </summary>
        [JsonProperty("out_trade_no")]
        public string OutTradeNo { get; set; }

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
        /// 货币种类
        /// </summary>
        [JsonProperty("fee_type")]
        public string FeeType { get; set; }

        /// <summary>
        /// 现金支付金额	
        /// </summary>
        [JsonProperty("cash_fee")]
        public int CashFee { get; set; }

        /// <summary>
        /// 退款笔数	
        /// </summary>
        [JsonProperty("refund_count")]
        public int RefundCount { get; set; }

        // 商户退款单号	out_refund_no_$n
        // 微信退款单号	refund_id_$n
        // 退款渠道	refund_channel_$n

        /// <summary>
        /// 订单总退款次数	
        /// </summary>
        [JsonProperty("total_refund_count")]
        public int TotalRefundCount { get; set; }

        // 申请退款金额	refund_fee_$n
        // 退款金额	settlement_refund_fee_$n
        // 代金券类型	 coupon_type_$n_$m
        // 总代金券退款金额	coupon_refund_fee_$n	
        // 退款代金券使用数量	coupon_refund_count_$n
        // 退款代金券ID	coupon_refund_id_$n_$m
        // 单个代金券退款金额	coupon_refund_fee_$n_$m
        // 退款状态	refund_status_$n
        // 退款资金来源	refund_account_$n
        // 退款入账账户	refund_recv_accout_$n
        // 退款成功时间	refund_success_time_$n
    }
}
