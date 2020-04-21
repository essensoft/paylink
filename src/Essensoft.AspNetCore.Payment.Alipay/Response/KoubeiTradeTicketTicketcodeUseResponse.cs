using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// KoubeiTradeTicketTicketcodeUseResponse.
    /// </summary>
    public class KoubeiTradeTicketTicketcodeUseResponse : AlipayResponse
    {
        /// <summary>
        /// 该字段用于描述本次返回中的业务属性，现有：BIZ_ALREADY_SUCCESS（幂等业务码）
        /// </summary>
        [JsonPropertyName("biz_code")]
        public string BizCode { get; set; }

        /// <summary>
        /// 用户购买券的时候实际支付的金额，单位为元，精确到小数点后两位，一次性核销多份券场景，返回总实际支付金额
        /// </summary>
        [JsonPropertyName("buyer_pay_amount")]
        public string BuyerPayAmount { get; set; }

        /// <summary>
        /// 用户购买时商品的现价，单位为元，精确到小数点后两位
        /// </summary>
        [JsonPropertyName("current_price")]
        public string CurrentPrice { get; set; }

        /// <summary>
        /// 商家优惠金额，单位为元，精确到小数点后两位，一次性核销多份券场景，返回总商家优惠金额
        /// </summary>
        [JsonPropertyName("discount_amount")]
        public string DiscountAmount { get; set; }

        /// <summary>
        /// 交易中可给用户开具发票的金额，单位为元，精确到小数点后两位，一次性核销多份券场景，返回总开票金额
        /// </summary>
        [JsonPropertyName("invoice_amount")]
        public string InvoiceAmount { get; set; }

        /// <summary>
        /// 凭证对应商品别名，在口碑商品创建时候设置
        /// </summary>
        [JsonPropertyName("item_alias")]
        public string ItemAlias { get; set; }

        /// <summary>
        /// 口碑商品ID
        /// </summary>
        [JsonPropertyName("item_id")]
        public string ItemId { get; set; }

        /// <summary>
        /// 用户购买时商品的名称
        /// </summary>
        [JsonPropertyName("item_name")]
        public string ItemName { get; set; }

        /// <summary>
        /// 口碑补贴金额，单位为元，精确到小数点后两位，一次性核销多份券场景，返回总口碑补贴金额
        /// </summary>
        [JsonPropertyName("koubei_subsidy_amount")]
        public string KoubeiSubsidyAmount { get; set; }

        /// <summary>
        /// 凭证码所属的订单id
        /// </summary>
        [JsonPropertyName("order_no")]
        public string OrderNo { get; set; }

        /// <summary>
        /// 用户购买时商品的原价，单位为元，精确到小数点后两位
        /// </summary>
        [JsonPropertyName("original_price")]
        public string OriginalPrice { get; set; }

        /// <summary>
        /// 商家实收金额，单位为元，精确到小数点后两位，一次性核销多份券场景，返回总商家实收金额
        /// </summary>
        [JsonPropertyName("receipt_amount")]
        public string ReceiptAmount { get; set; }

        /// <summary>
        /// 外部请求号，支持英文字母和数字，由开发者自行定义（不允许重复）
        /// </summary>
        [JsonPropertyName("request_id")]
        public string RequestId { get; set; }

        /// <summary>
        /// 12位的券码，券码为纯数字，且唯一不重复
        /// </summary>
        [JsonPropertyName("ticket_code")]
        public string TicketCode { get; set; }

        /// <summary>
        /// 核销流水号
        /// </summary>
        [JsonPropertyName("ticket_trans_id")]
        public string TicketTransId { get; set; }

        /// <summary>
        /// 非次卡一次性核销多份场景，被核销的凭证明细信息
        /// </summary>
        [JsonPropertyName("ticket_use_details")]
        public List<KbTicketUseDetail> TicketUseDetails { get; set; }

        /// <summary>
        /// 券核销时间
        /// </summary>
        [JsonPropertyName("use_date")]
        public string UseDate { get; set; }

        /// <summary>
        /// 券核销门店ID
        /// </summary>
        [JsonPropertyName("use_shop_id")]
        public string UseShopId { get; set; }

        /// <summary>
        /// 券核销门店名称
        /// </summary>
        [JsonPropertyName("use_shop_name")]
        public string UseShopName { get; set; }

        /// <summary>
        /// 凭证码对应的凭证资产id
        /// </summary>
        [JsonPropertyName("voucher_id")]
        public string VoucherId { get; set; }
    }
}
