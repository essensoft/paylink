using System.Xml.Serialization;
using Newtonsoft.Json;

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
        [JsonProperty("biz_code")]
        [XmlElement("biz_code")]
        public string BizCode { get; set; }

        /// <summary>
        /// 用户购买券的时候实际支付的金额，单位为元，精确到小数点后两位
        /// </summary>
        [JsonProperty("buyer_pay_amount")]
        [XmlElement("buyer_pay_amount")]
        public string BuyerPayAmount { get; set; }

        /// <summary>
        /// 用户购买时商品的现价，单位为元，精确到小数点后两位
        /// </summary>
        [JsonProperty("current_price")]
        [XmlElement("current_price")]
        public string CurrentPrice { get; set; }

        /// <summary>
        /// 商家优惠金额，单位为元，精确到小数点后两位
        /// </summary>
        [JsonProperty("discount_amount")]
        [XmlElement("discount_amount")]
        public string DiscountAmount { get; set; }

        /// <summary>
        /// 交易中可给用户开具发票的金额，单位为元，精确到小数点后两位
        /// </summary>
        [JsonProperty("invoice_amount")]
        [XmlElement("invoice_amount")]
        public string InvoiceAmount { get; set; }

        /// <summary>
        /// 口碑商品ID
        /// </summary>
        [JsonProperty("item_id")]
        [XmlElement("item_id")]
        public string ItemId { get; set; }

        /// <summary>
        /// 用户购买时商品的名称
        /// </summary>
        [JsonProperty("item_name")]
        [XmlElement("item_name")]
        public string ItemName { get; set; }

        /// <summary>
        /// 口碑补贴金额，单位为元，精确到小数点后两位
        /// </summary>
        [JsonProperty("koubei_subsidy_amount")]
        [XmlElement("koubei_subsidy_amount")]
        public string KoubeiSubsidyAmount { get; set; }

        /// <summary>
        /// 凭证码所属的订单id
        /// </summary>
        [JsonProperty("order_no")]
        [XmlElement("order_no")]
        public string OrderNo { get; set; }

        /// <summary>
        /// 用户购买时商品的原价，单位为元，精确到小数点后两位
        /// </summary>
        [JsonProperty("original_price")]
        [XmlElement("original_price")]
        public string OriginalPrice { get; set; }

        /// <summary>
        /// 商家实收金额，单位为元，精确到小数点后两位
        /// </summary>
        [JsonProperty("receipt_amount")]
        [XmlElement("receipt_amount")]
        public string ReceiptAmount { get; set; }

        /// <summary>
        /// 外部请求号，支持英文字母和数字，由开发者自行定义（不允许重复）
        /// </summary>
        [JsonProperty("request_id")]
        [XmlElement("request_id")]
        public string RequestId { get; set; }

        /// <summary>
        /// 12位的券码，券码为纯数字，且唯一不重复
        /// </summary>
        [JsonProperty("ticket_code")]
        [XmlElement("ticket_code")]
        public string TicketCode { get; set; }

        /// <summary>
        /// 核销流水号
        /// </summary>
        [JsonProperty("ticket_trans_id")]
        [XmlElement("ticket_trans_id")]
        public string TicketTransId { get; set; }

        /// <summary>
        /// 券核销时间
        /// </summary>
        [JsonProperty("use_date")]
        [XmlElement("use_date")]
        public string UseDate { get; set; }

        /// <summary>
        /// 券核销门店ID
        /// </summary>
        [JsonProperty("use_shop_id")]
        [XmlElement("use_shop_id")]
        public string UseShopId { get; set; }

        /// <summary>
        /// 券核销门店名称
        /// </summary>
        [JsonProperty("use_shop_name")]
        [XmlElement("use_shop_name")]
        public string UseShopName { get; set; }

        /// <summary>
        /// 凭证码对应的凭证资产id
        /// </summary>
        [JsonProperty("voucher_id")]
        [XmlElement("voucher_id")]
        public string VoucherId { get; set; }
    }
}
