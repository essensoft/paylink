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
        /// 商户退款单号	
        /// </summary>
        [JsonProperty("out_refund_no")]
        public string OutRefundNo { get; set; }

        /// <summary>
        /// 微信退款单号	
        /// </summary>
        [JsonProperty("refund_id")]
        public string RefundId { get; set; }

        /// <summary>
        /// 申请退款金额	
        /// </summary>
        [JsonProperty("refund_fee")]
        public string RefundFee { get; set; }

        /// <summary>
        /// 退款金额	
        /// </summary>
        [JsonProperty("settlement_refund_fee")]
        public string SettlementRefundFee { get; set; }

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
        /// 现金退款金额	
        /// </summary>
        [JsonProperty("cash_refund_fee")]
        public int CashRefundFee { get; set; }

        /// <summary>
        /// 代金券退款总金额	
        /// </summary>
        [JsonProperty("coupon_refund_fee")]
        public int RefundCount { get; set; }

        /// <summary>
        /// 退款代金券使用数量	
        /// </summary>
        [JsonProperty("coupon_refund_count")]
        public int CouponRefundCount { get; set; }

        // 代金券类型 coupon_type_$n

        /// <summary>
        /// 代金券类型 0 	
        /// </summary>
        [JsonProperty("coupon_type_0")]
        public int CouponType0 { get; set; }

        // 退款代金券ID coupon_refund_id_$n

        /// <summary>
        /// 退款代金券ID 0
        /// </summary>
        [JsonProperty("coupon_refund_id_0")]
        public int CouponRefund0 { get; set; }

        // 单个代金券退款金额 coupon_refund_fee_$n

        /// <summary>
        /// 单个代金券退款金额 0
        /// </summary>
        [JsonProperty("coupon_refund_fee_0")]
        public int CouponRefundFee0 { get; set; }
    }
}
