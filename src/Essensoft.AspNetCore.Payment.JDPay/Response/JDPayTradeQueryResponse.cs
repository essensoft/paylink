using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.JDPay.Response
{
    public class JDPayTradeQueryResponse : JDPayResponse
    {
        /// <summary>
        /// 提交者会员号
        /// </summary>
        [JsonProperty("customer_no")]
        public string CustomerNo { get; set; }

        /// <summary>
        /// 响应时间
        /// </summary>
        [JsonProperty("response_datetime")]
        public string ResponseDatetime { get; set; }

        /// <summary>
        /// 响应编码
        /// </summary>
        [JsonProperty("response_code")]
        public string ResponseCode { get; set; }

        /// <summary>
        /// 响应描述
        /// </summary>
        [JsonProperty("response_message")]
        public string ResponseMessage { get; set; }

        /// <summary>
        /// 签名方式
        /// </summary>
        [JsonProperty("sign_type")]
        public string SignType { get; set; }

        /// <summary>
        /// 签名数据
        /// </summary>
        [JsonProperty("sign_data")]
        public string SignData { get; set; }

        /// <summary>
        /// 商户订单流水号
        /// </summary>
        [JsonProperty("out_trade_no")]
        public string OutTradeNo { get; set; }

        /// <summary>
        /// 业务订单流水号
        /// </summary>
        [JsonProperty("biz_trade_no")]
        public string BizTradeNo { get; set; }

        /// <summary>
        /// 外部交易日
        /// </summary>
        [JsonProperty("out_trade_date")]
        public string OutTradeDate { get; set; }

        /// <summary>
        /// 交易类别
        /// </summary>
        [JsonProperty("trade_class")]
        public string TradeClass { get; set; }

        /// <summary>
        /// 订单摘要
        /// </summary>
        [JsonProperty("trade_subject")]
        public string TradeSubject { get; set; }

        /// <summary>
        /// 交易号
        /// </summary>
        [JsonProperty("trade_no")]
        public string TradeNo { get; set; }

        /// <summary>
        /// 卖方信息
        /// </summary>
        [JsonProperty("seller_info")]
        public string SellerInfo { get; set; }

        /// <summary>
        /// 买方信息
        /// </summary>
        [JsonProperty("buyer_info")]
        public string BuyerInfo { get; set; }

        /// <summary>
        /// 订单交易金额
        /// </summary>
        [JsonProperty("trade_amount")]
        public string TradeAmount { get; set; }

        /// <summary>
        /// 订单交易币种
        /// </summary>
        [JsonProperty("trade_currency")]
        public string TradeCurrency { get; set; }

        /// <summary>
        /// 已退款金额
        /// </summary>
        [JsonProperty("refund_amount")]
        public string RefundAmount { get; set; }

        /// <summary>
        /// 商户售卖的商品分类码
        /// </summary>
        [JsonProperty("category_code")]
        public string CategoryCode { get; set; }

        /// <summary>
        /// 已确认金额
        /// </summary>
        [JsonProperty("confirm_amount")]
        public string ConfirmAmount { get; set; }

        /// <summary>
        /// 交易响应码
        /// </summary>
        [JsonProperty("trade_respcode")]
        public string TradeRespcode { get; set; }

        /// <summary>
        /// 交易响应描述
        /// </summary>
        [JsonProperty("trade_respmsg")]
        public string TradeRespmsg { get; set; }

        /// <summary>
        /// 交易状态
        /// </summary>
        [JsonProperty("trade_status")]
        public string TradeStatus { get; set; }

        /// <summary>
        /// 支付完成日
        /// </summary>
        [JsonProperty("trade_pay_date")]
        public string TradePayDate { get; set; }

        /// <summary>
        /// 支付完时间
        /// </summary>
        [JsonProperty("trade_pay_time")]
        public string TradePayTime { get; set; }

        /// <summary>
        /// 支付工具
        /// </summary>
        [JsonProperty("pay_tool")]
        public string PayTool { get; set; }

        /// <summary>
        /// 支付银行
        /// </summary>
        [JsonProperty("bank_code")]
        public string BankCode { get; set; }

        /// <summary>
        /// 支付卡种
        /// </summary>
        [JsonProperty("card_type")]
        public string CardType { get; set; }

        /// <summary>
        /// 交易完成日
        /// </summary>
        [JsonProperty("trade_finish_date")]
        public string TradeFinishDate { get; set; }

        /// <summary>
        /// 交易完时间
        /// </summary>
        [JsonProperty("trade_finish_time")]
        public string TradeFinishTime { get; set; }

        /// <summary>
        /// 订单返回信息
        /// </summary>
        [JsonProperty("return_params")]
        public string ReturnParams { get; set; }
    }
}
