using Newtonsoft.Json;
using System.Collections.Generic;
using Essensoft.AspNetCore.Alipay.Domain;

namespace Essensoft.AspNetCore.Alipay.Response
{
    /// <summary>
    /// AlipayTradePayResponse.
    /// </summary>
    public class AlipayTradePayResponse : AlipayResponse
    {
        /// <summary>
        /// 异步支付模式，先享后付业务会返回该参数，目前有三种值：  ASYNC_DELAY_PAY(异步延时付款);  ASYNC_REALTIME_PAY(异步准实时付款);  SYNC_DIRECT_PAY(同步直接扣款);
        /// </summary>
        [JsonProperty("async_payment_mode")]
        public string AsyncPaymentMode { get; set; }

        /// <summary>
        /// 商户传入业务信息，具体值要和支付宝约定  将商户传入信息分发给相应系统，应用于安全，营销等参数直传场景  格式为json格式
        /// </summary>
        [JsonProperty("business_params")]
        public string BusinessParams { get; set; }

        /// <summary>
        /// 买家支付宝账号
        /// </summary>
        [JsonProperty("buyer_logon_id")]
        public string BuyerLogonId { get; set; }

        /// <summary>
        /// 买家付款的金额
        /// </summary>
        [JsonProperty("buyer_pay_amount")]
        public string BuyerPayAmount { get; set; }

        /// <summary>
        /// 买家在支付宝的用户id
        /// </summary>
        [JsonProperty("buyer_user_id")]
        public string BuyerUserId { get; set; }

        /// <summary>
        /// 支付宝卡余额
        /// </summary>
        [JsonProperty("card_balance")]
        public string CardBalance { get; set; }

        /// <summary>
        /// 本次交易支付所使用的单品券优惠的商品优惠信息
        /// </summary>
        [JsonProperty("discount_goods_detail")]
        public string DiscountGoodsDetail { get; set; }

        /// <summary>
        /// 交易支付使用的资金渠道
        /// </summary>
        [JsonProperty("fund_bill_list")]
        public List<TradeFundBill> FundBillList { get; set; }

        /// <summary>
        /// 交易支付时间
        /// </summary>
        [JsonProperty("gmt_payment")]
        public string GmtPayment { get; set; }

        /// <summary>
        /// 交易中可给用户开具发票的金额
        /// </summary>
        [JsonProperty("invoice_amount")]
        public string InvoiceAmount { get; set; }

        /// <summary>
        /// 买家支付宝用户号,该参数已废弃，请不要使用
        /// </summary>
        [JsonProperty("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 商户订单号
        /// </summary>
        [JsonProperty("out_trade_no")]
        public string OutTradeNo { get; set; }

        /// <summary>
        /// 使用积分宝付款的金额
        /// </summary>
        [JsonProperty("point_amount")]
        public string PointAmount { get; set; }

        /// <summary>
        /// 实收金额
        /// </summary>
        [JsonProperty("receipt_amount")]
        public string ReceiptAmount { get; set; }

        /// <summary>
        /// 发生支付交易的商户门店名称
        /// </summary>
        [JsonProperty("store_name")]
        public string StoreName { get; set; }

        /// <summary>
        /// 交易金额
        /// </summary>
        [JsonProperty("total_amount")]
        public string TotalAmount { get; set; }

        /// <summary>
        /// 支付宝交易号
        /// </summary>
        [JsonProperty("trade_no")]
        public string TradeNo { get; set; }

        /// <summary>
        /// 本交易支付时使用的所有优惠券信息
        /// </summary>
        [JsonProperty("voucher_detail_list")]
        public List<VoucherDetail> VoucherDetailList { get; set; }
    }
}
