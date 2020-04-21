using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayTradeQueryResponse.
    /// </summary>
    public class AlipayTradeQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 支付宝店铺编号
        /// </summary>
        [JsonPropertyName("alipay_store_id")]
        public string AlipayStoreId { get; set; }

        /// <summary>
        /// 间连商户在支付宝端的商户编号；  只在间连场景下返回；
        /// </summary>
        [JsonPropertyName("alipay_sub_merchant_id")]
        public string AlipaySubMerchantId { get; set; }

        /// <summary>
        /// 预授权支付模式，该参数仅在信用预授权支付场景下返回。信用预授权支付：CREDIT_PREAUTH_PAY
        /// </summary>
        [JsonPropertyName("auth_trade_pay_mode")]
        public string AuthTradePayMode { get; set; }

        /// <summary>
        /// 订单描述;  只在间连场景下返回；
        /// </summary>
        [JsonPropertyName("body")]
        public new string Body { get; set; }

        /// <summary>
        /// 买家支付宝账号
        /// </summary>
        [JsonPropertyName("buyer_logon_id")]
        public string BuyerLogonId { get; set; }

        /// <summary>
        /// 买家实付金额，单位为元，两位小数。该金额代表该笔交易买家实际支付的金额，不包含商户折扣等金额
        /// </summary>
        [JsonPropertyName("buyer_pay_amount")]
        public string BuyerPayAmount { get; set; }

        /// <summary>
        /// 买家在支付宝的用户id
        /// </summary>
        [JsonPropertyName("buyer_user_id")]
        public string BuyerUserId { get; set; }

        /// <summary>
        /// 买家名称；  买家为个人用户时为买家姓名，买家为企业用户时为企业名称；  默认不返回该信息，需与支付宝约定后配置返回；
        /// </summary>
        [JsonPropertyName("buyer_user_name")]
        public string BuyerUserName { get; set; }

        /// <summary>
        /// 买家用户类型。CORPORATE:企业用户；PRIVATE:个人用户。
        /// </summary>
        [JsonPropertyName("buyer_user_type")]
        public string BuyerUserType { get; set; }

        /// <summary>
        /// 该笔交易针对收款方的收费金额；  默认不返回该信息，需与支付宝约定后配置返回；
        /// </summary>
        [JsonPropertyName("charge_amount")]
        public string ChargeAmount { get; set; }

        /// <summary>
        /// 费率活动标识，当交易享受活动优惠费率时，返回该活动的标识；  默认不返回该信息，需与支付宝约定后配置返回；  可能的返回值列表：  蓝海活动标识：bluesea_1
        /// </summary>
        [JsonPropertyName("charge_flags")]
        public string ChargeFlags { get; set; }

        /// <summary>
        /// 平台优惠金额
        /// </summary>
        [JsonPropertyName("discount_amount")]
        public string DiscountAmount { get; set; }

        /// <summary>
        /// 本次交易支付所使用的单品券优惠的商品优惠信息。 只有在query_options中指定时才返回该字段信息。
        /// </summary>
        [JsonPropertyName("discount_goods_detail")]
        public string DiscountGoodsDetail { get; set; }

        /// <summary>
        /// 交易额外信息，特殊场景下与支付宝约定返回。 json格式。
        /// </summary>
        [JsonPropertyName("ext_infos")]
        public string ExtInfos { get; set; }

        /// <summary>
        /// 交易支付使用的资金渠道。 只有在签约中指定需要返回资金明细，或者入参的query_options中指定时才返回该字段信息。
        /// </summary>
        [JsonPropertyName("fund_bill_list")]
        public List<TradeFundBill> FundBillList { get; set; }

        /// <summary>
        /// 行业特殊信息（例如在医保卡支付业务中，向用户返回医疗信息）。
        /// </summary>
        [JsonPropertyName("industry_sepc_detail")]
        public string IndustrySepcDetail { get; set; }

        /// <summary>
        /// 交易中用户支付的可开具发票的金额，单位为元，两位小数。该金额代表该笔交易中可以给用户开具发票的金额
        /// </summary>
        [JsonPropertyName("invoice_amount")]
        public string InvoiceAmount { get; set; }

        /// <summary>
        /// 商家优惠金额
        /// </summary>
        [JsonPropertyName("mdiscount_amount")]
        public string MdiscountAmount { get; set; }

        /// <summary>
        /// 买家支付宝用户号，该字段将废弃，不要使用
        /// </summary>
        [JsonPropertyName("open_id")]
        public string OpenId { get; set; }

        /// <summary>
        /// 商家订单号
        /// </summary>
        [JsonPropertyName("out_trade_no")]
        public string OutTradeNo { get; set; }

        /// <summary>
        /// 支付币种订单金额
        /// </summary>
        [JsonPropertyName("pay_amount")]
        public string PayAmount { get; set; }

        /// <summary>
        /// 订单支付币种
        /// </summary>
        [JsonPropertyName("pay_currency")]
        public string PayCurrency { get; set; }

        /// <summary>
        /// 积分支付的金额，单位为元，两位小数。该金额代表该笔交易中用户使用积分支付的金额，比如集分宝或者支付宝实时优惠等
        /// </summary>
        [JsonPropertyName("point_amount")]
        public string PointAmount { get; set; }

        /// <summary>
        /// 实收金额，单位为元，两位小数。该金额为本笔交易，商户账户能够实际收到的金额
        /// </summary>
        [JsonPropertyName("receipt_amount")]
        public string ReceiptAmount { get; set; }

        /// <summary>
        /// 本次交易打款给卖家的时间
        /// </summary>
        [JsonPropertyName("send_pay_date")]
        public string SendPayDate { get; set; }

        /// <summary>
        /// 结算币种订单金额
        /// </summary>
        [JsonPropertyName("settle_amount")]
        public string SettleAmount { get; set; }

        /// <summary>
        /// 订单结算币种，对应支付接口传入的settle_currency，支持英镑：GBP、港币：HKD、美元：USD、新加坡元：SGD、日元：JPY、加拿大元：CAD、澳元：AUD、欧元：EUR、新西兰元：NZD、韩元：KRW、泰铢：THB、瑞士法郎：CHF、瑞典克朗：SEK、丹麦克朗：DKK、挪威克朗：NOK、马来西亚林吉特：MYR、印尼卢比：IDR、菲律宾比索：PHP、毛里求斯卢比：MUR、以色列新谢克尔：ILS、斯里兰卡卢比：LKR、俄罗斯卢布：RUB、阿联酋迪拉姆：AED、捷克克朗：CZK、南非兰特：ZAR
        /// </summary>
        [JsonPropertyName("settle_currency")]
        public string SettleCurrency { get; set; }

        /// <summary>
        /// 结算币种兑换标价币种汇率
        /// </summary>
        [JsonPropertyName("settle_trans_rate")]
        public string SettleTransRate { get; set; }

        /// <summary>
        /// 支付清算编号，用于清算对账使用；  只在银行间联交易场景下返回该信息；
        /// </summary>
        [JsonPropertyName("settlement_id")]
        public string SettlementId { get; set; }

        /// <summary>
        /// 商户门店编号
        /// </summary>
        [JsonPropertyName("store_id")]
        public string StoreId { get; set; }

        /// <summary>
        /// 请求交易支付中的商户店铺的名称
        /// </summary>
        [JsonPropertyName("store_name")]
        public string StoreName { get; set; }

        /// <summary>
        /// 订单标题；  只在间连场景下返回；
        /// </summary>
        [JsonPropertyName("subject")]
        public string Subject { get; set; }

        /// <summary>
        /// 商户机具终端编号
        /// </summary>
        [JsonPropertyName("terminal_id")]
        public string TerminalId { get; set; }

        /// <summary>
        /// 交易的订单金额，单位为元，两位小数。该参数的值为支付时传入的total_amount
        /// </summary>
        [JsonPropertyName("total_amount")]
        public string TotalAmount { get; set; }

        /// <summary>
        /// 支付宝交易号
        /// </summary>
        [JsonPropertyName("trade_no")]
        public string TradeNo { get; set; }

        /// <summary>
        /// 返回的交易结算信息，包含分账、补差等信息。 只有在query_options中指定时才返回该字段信息。
        /// </summary>
        [JsonPropertyName("trade_settle_info")]
        public TradeSettleInfo TradeSettleInfo { get; set; }

        /// <summary>
        /// 交易状态：WAIT_BUYER_PAY（交易创建，等待买家付款）、TRADE_CLOSED（未付款交易超时关闭，或支付完成后全额退款）、TRADE_SUCCESS（交易支付成功）、TRADE_FINISHED（交易结束，不可退款）
        /// </summary>
        [JsonPropertyName("trade_status")]
        public string TradeStatus { get; set; }

        /// <summary>
        /// 标价币种，该参数的值为支付时传入的trans_currency，支持英镑：GBP、港币：HKD、美元：USD、新加坡元：SGD、日元：JPY、加拿大元：CAD、澳元：AUD、欧元：EUR、新西兰元：NZD、韩元：KRW、泰铢：THB、瑞士法郎：CHF、瑞典克朗：SEK、丹麦克朗：DKK、挪威克朗：NOK、马来西亚林吉特：MYR、印尼卢比：IDR、菲律宾比索：PHP、毛里求斯卢比：MUR、以色列新谢克尔：ILS、斯里兰卡卢比：LKR、俄罗斯卢布：RUB、阿联酋迪拉姆：AED、捷克克朗：CZK、南非兰特：ZAR、人民币：CNY、新台币：TWD。当trans_currency 和 settle_currency 不一致时，trans_currency支持人民币：CNY、新台币：TWD
        /// </summary>
        [JsonPropertyName("trans_currency")]
        public string TransCurrency { get; set; }

        /// <summary>
        /// 标价币种兑换支付币种汇率
        /// </summary>
        [JsonPropertyName("trans_pay_rate")]
        public string TransPayRate { get; set; }

        /// <summary>
        /// 本交易支付时使用的所有优惠券信息。 只有在query_options中指定时才返回该字段信息。
        /// </summary>
        [JsonPropertyName("voucher_detail_list")]
        public List<VoucherDetail> VoucherDetailList { get; set; }
    }
}
