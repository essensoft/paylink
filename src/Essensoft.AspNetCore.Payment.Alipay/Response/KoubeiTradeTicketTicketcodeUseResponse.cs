using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// KoubeiTradeTicketTicketcodeUseResponse.
    /// </summary>
    public class KoubeiTradeTicketTicketcodeUseResponse : AlipayResponse
    {
        /// <summary>
        /// 用户购买券的时候实际支付的金额，单位为元，精确到小数点后两位
        /// </summary>
        [JsonProperty("buyer_pay_amount")]
        public string BuyerPayAmount { get; set; }

        /// <summary>
        /// 用户购买时商品的现价，单位为元，精确到小数点后两位
        /// </summary>
        [JsonProperty("current_price")]
        public string CurrentPrice { get; set; }

        /// <summary>
        /// 商家优惠金额，单位为元，精确到小数点后两位
        /// </summary>
        [JsonProperty("discount_amount")]
        public string DiscountAmount { get; set; }

        /// <summary>
        /// 交易中可给用户开具发票的金额，单位为元，精确到小数点后两位
        /// </summary>
        [JsonProperty("invoice_amount")]
        public string InvoiceAmount { get; set; }

        /// <summary>
        /// 口碑商品ID
        /// </summary>
        [JsonProperty("item_id")]
        public string ItemId { get; set; }

        /// <summary>
        /// 用户购买时商品的名称
        /// </summary>
        [JsonProperty("item_name")]
        public string ItemName { get; set; }

        /// <summary>
        /// 口碑补贴金额，单位为元，精确到小数点后两位
        /// </summary>
        [JsonProperty("koubei_subsidy_amount")]
        public string KoubeiSubsidyAmount { get; set; }

        /// <summary>
        /// 券码所属的订单id
        /// </summary>
        [JsonProperty("order_no")]
        public string OrderNo { get; set; }

        /// <summary>
        /// 用户购买时商品的原价，单位为元，精确到小数点后两位
        /// </summary>
        [JsonProperty("original_price")]
        public string OriginalPrice { get; set; }

        /// <summary>
        /// 商家实收金额，单位为元，精确到小数点后两位
        /// </summary>
        [JsonProperty("receipt_amount")]
        public string ReceiptAmount { get; set; }

        /// <summary>
        /// 外部请求号，支持英文字母和数字，由开发者自行定义（不允许重复）
        /// </summary>
        [JsonProperty("request_id")]
        public string RequestId { get; set; }

        /// <summary>
        /// 12位的券码，券码为纯数字，且唯一不重复
        /// </summary>
        [JsonProperty("ticket_code")]
        public string TicketCode { get; set; }

        /// <summary>
        /// 核销流水号
        /// </summary>
        [JsonProperty("ticket_trans_id")]
        public string TicketTransId { get; set; }

        /// <summary>
        /// 券核销时间
        /// </summary>
        [JsonProperty("use_date")]
        public string UseDate { get; set; }

        /// <summary>
        /// 券核销门店ID
        /// </summary>
        [JsonProperty("use_shop_id")]
        public string UseShopId { get; set; }

        /// <summary>
        /// 券核销门店名称
        /// </summary>
        [JsonProperty("use_shop_name")]
        public string UseShopName { get; set; }

        /// <summary>
        /// 券码对应的凭证资产id
        /// </summary>
        [JsonProperty("voucher_id")]
        public string VoucherId { get; set; }
    }
}
