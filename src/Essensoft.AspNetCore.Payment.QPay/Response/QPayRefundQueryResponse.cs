using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.QPay.Response
{
    public class QPayRefundQueryResponse : QPayResponse
    {
        /// <summary>
        /// 返回状态码
        /// 此字段是通信标识，非交易标识，
        /// 交易是否成功需要查看result_code来判断
        /// </summary>
        [JsonProperty("return_code")]
        public string ReturnCode { get; set; }

        /// <summary>
        /// 返回信息
        /// </summary>
        [JsonProperty("return_msg")]
        public string ReturnMsg { get; set; }

        /// <summary>
        /// 手Q CGI原始错误码
        /// </summary>
        [JsonProperty("retcode")]
        public string RetCode { get; set; }

        /// <summary>
        /// 手Q CGI原始错误信息
        /// </summary>
        [JsonProperty("retmsg")]
        public string RetMsg { get; set; }

        /// <summary>
        /// 公众账号ID
        /// </summary>
        [JsonProperty("appid")]
        public string AppId { get; set; }

        /// <summary>
        /// 商户号ID
        /// </summary>
        [JsonProperty("mch_id")]
        public string MchId { get; set; }

        /// <summary>
        /// 签名
        /// </summary>
        [JsonProperty("sign")]
        public string Sign { get; set; }

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
        /// 随机字符串
        /// </summary>
        [JsonProperty("nonce_str")]
        public string NonceStr { get; set; }

        /// <summary>
        /// QQ钱包订单号	
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
        /// 用户支付金额	
        /// </summary>
        [JsonProperty("cash_fee")]
        public int CashFee { get; set; }

        /// <summary>
        /// 货币类型定义
        /// </summary>
        [JsonProperty("fee_type")]
        public string FeeType { get; set; }

        // out_refund_no_$n 商户退款单号

        /// <summary>
        /// 商户退款单号
        /// </summary>
        [JsonProperty("out_refund_no_0")]
        public string OutRefundNo0 { get; set; }

        // refund_id_$n QQ钱包退款单号

        /// <summary>
        /// QQ钱包退款单号
        /// </summary>
        [JsonProperty("refund_id_0")]
        public string RefundId0 { get; set; }

        // refund_channel_$n 退款方式

        /// <summary>
        /// 退款方式 0
        /// </summary>
        [JsonProperty("refund_channel_0")]
        public string RefundChannel0 { get; set; }

        // refund_fee_$n 退款申请金额

        /// <summary>
        /// 商户退款单号 0
        /// </summary>
        [JsonProperty("refund_fee_0")]
        public string RefundFee0 { get; set; }

        // coupon_refund_fee_$n 退款申请金额中，优惠或者立减的金额

        /// <summary>
        /// 退款申请金额中，优惠或者立减的金额 0
        /// </summary>
        [JsonProperty("coupon_refund_fee_0")]
        public string CouponRefundFee_0 { get; set; }

        // cash_refund_fee_$n 退款申请中的现金金额

        /// <summary>
        /// 退款申请中的现金金额 0
        /// </summary>
        [JsonProperty("cash_refund_fee_0")]
        public string CashRefundFee0 { get; set; }

        // refund_status_$n 退款状态定义

        /// <summary>
        /// 退款状态定义 0
        /// </summary>
        [JsonProperty("refund_status_0")]
        public string RefundStatus0 { get; set; }

        // refund_recv_accout_$n 退款入账账户

        /// <summary>
        /// 退款入账账户 0
        /// </summary>
        [JsonProperty("refund_recv_accout_0")]
        public string RefundRecvAccout0 { get; set; }
    }
}
