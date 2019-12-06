using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KoubeiTradeTicketTicketcodeUseModel Data Structure.
    /// </summary>
    public class KoubeiTradeTicketTicketcodeUseModel : AlipayObject
    {
        /// <summary>
        /// 凭证码类型,INTERNAL_CODE(内部凭证码),EXTERNAL_CODE(外部凭证码),默认INTERNAL_CODE,外部券场景必填
        /// </summary>
        [JsonPropertyName("code_type")]
        public string CodeType { get; set; }

        /// <summary>
        /// 业务发生时间，默认为接口调用时间
        /// </summary>
        [JsonPropertyName("gmt_biz")]
        public string GmtBiz { get; set; }

        /// <summary>
        /// 口碑订单号，使用外部凭证码核销时必填
        /// </summary>
        [JsonPropertyName("order_no")]
        public string OrderNo { get; set; }

        /// <summary>
        /// 核销份数，次卡业务必填、非次卡业务选填， 非次卡场景表示核销同一订单下的同类凭证的个数
        /// </summary>
        [JsonPropertyName("quantity")]
        public string Quantity { get; set; }

        /// <summary>
        /// 外部请求号，支持英文字母和数字，由开发者自行定义（不允许重复）
        /// </summary>
        [JsonPropertyName("request_id")]
        public string RequestId { get; set; }

        /// <summary>
        /// 口碑门店id
        /// </summary>
        [JsonPropertyName("shop_id")]
        public string ShopId { get; set; }

        /// <summary>
        /// 门店id类型,INTERNAL_SHOP(内部店铺id),EXTERNAL_SHOP(外部店铺id),默认INTERNAL_SHOP
        /// </summary>
        [JsonPropertyName("shop_type")]
        public string ShopType { get; set; }

        /// <summary>
        /// 凭证码，包括内部凭证码和外部凭证码，内部凭证码为12位，纯数字，且唯一不重复
        /// </summary>
        [JsonPropertyName("ticket_code")]
        public string TicketCode { get; set; }
    }
}
