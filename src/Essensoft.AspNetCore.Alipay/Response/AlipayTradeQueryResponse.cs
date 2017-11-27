using Newtonsoft.Json;
using System.Collections.Generic;
using Essensoft.AspNetCore.Alipay.Domain;

namespace Essensoft.AspNetCore.Alipay.Response
{
    /// <summary>
    /// AlipayTradeQueryResponse.
    /// </summary>
    public class AlipayTradeQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 支付宝店铺编号
        /// </summary>
        [JsonProperty("alipay_store_id")]
        public string AlipayStoreId { get; set; }

        /// <summary>
        /// 买家支付宝账号
        /// </summary>
        [JsonProperty("buyer_logon_id")]
        public string BuyerLogonId { get; set; }

        /// <summary>
        /// 买家实付金额，单位为元，两位小数。该金额代表该笔交易买家实际支付的金额，不包含商户折扣等金额
        /// </summary>
        [JsonProperty("buyer_pay_amount")]
        public string BuyerPayAmount { get; set; }

        /// <summary>
        /// 买家在支付宝的用户id
        /// </summary>
        [JsonProperty("buyer_user_id")]
        public string BuyerUserId { get; set; }

        /// <summary>
        /// 买家用户类型。CORPORATE:企业用户；PRIVATE:个人用户。
        /// </summary>
        [JsonProperty("buyer_user_type")]
        public string BuyerUserType { get; set; }

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
        /// 行业特殊信息（例如在医保卡支付业务中，向用户返回医疗信息）。
        /// </summary>
        [JsonProperty("industry_sepc_detail")]
        public string IndustrySepcDetail { get; set; }

        /// <summary>
        /// 交易中用户支付的可开具发票的金额，单位为元，两位小数。该金额代表该笔交易中可以给用户开具发票的金额
        /// </summary>
        [JsonProperty("invoice_amount")]
        public string InvoiceAmount { get; set; }

        /// <summary>
        /// 买家支付宝用户号，该字段将废弃，不要使用
        /// </summary>
        [JsonProperty("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 商家订单号
        /// </summary>
        [JsonProperty("out_trade_no")]
        public string OutTradeNo { get; set; }

        /// <summary>
        /// 积分支付的金额，单位为元，两位小数。该金额代表该笔交易中用户使用积分支付的金额，比如集分宝或者支付宝实时优惠等
        /// </summary>
        [JsonProperty("point_amount")]
        public string PointAmount { get; set; }

        /// <summary>
        /// 实收金额，单位为元，两位小数。该金额为本笔交易，商户账户能够实际收到的金额
        /// </summary>
        [JsonProperty("receipt_amount")]
        public string ReceiptAmount { get; set; }

        /// <summary>
        /// 本次交易打款给卖家的时间
        /// </summary>
        [JsonProperty("send_pay_date")]
        public string SendPayDate { get; set; }

        /// <summary>
        /// 商户门店编号
        /// </summary>
        [JsonProperty("store_id")]
        public string StoreId { get; set; }

        /// <summary>
        /// 请求交易支付中的商户店铺的名称
        /// </summary>
        [JsonProperty("store_name")]
        public string StoreName { get; set; }

        /// <summary>
        /// 商户机具终端编号
        /// </summary>
        [JsonProperty("terminal_id")]
        public string TerminalId { get; set; }

        /// <summary>
        /// 交易的订单金额，单位为元，两位小数。该参数的值为支付时传入的total_amount
        /// </summary>
        [JsonProperty("total_amount")]
        public string TotalAmount { get; set; }

        /// <summary>
        /// 支付宝交易号
        /// </summary>
        [JsonProperty("trade_no")]
        public string TradeNo { get; set; }

        /// <summary>
        /// 交易状态：WAIT_BUYER_PAY（交易创建，等待买家付款）、TRADE_CLOSED（未付款交易超时关闭，或支付完成后全额退款）、TRADE_SUCCESS（交易支付成功）、TRADE_FINISHED（交易结束，不可退款）
        /// </summary>
        [JsonProperty("trade_status")]
        public string TradeStatus { get; set; }

        /// <summary>
        /// 本交易支付时使用的所有优惠券信息
        /// </summary>
        [JsonProperty("voucher_detail_list")]
        public List<VoucherDetail> VoucherDetailList { get; set; }
    }
}
