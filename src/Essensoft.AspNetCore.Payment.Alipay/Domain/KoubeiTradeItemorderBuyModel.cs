using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KoubeiTradeItemorderBuyModel Data Structure.
    /// </summary>
    public class KoubeiTradeItemorderBuyModel : AlipayObject
    {
        /// <summary>
        /// 业务产品
        /// </summary>
        [JsonPropertyName("biz_product")]
        public string BizProduct { get; set; }

        /// <summary>
        /// 业务场景
        /// </summary>
        [JsonPropertyName("biz_scene")]
        public string BizScene { get; set; }

        /// <summary>
        /// 买家支付宝ID
        /// </summary>
        [JsonPropertyName("buyer_id")]
        public string BuyerId { get; set; }

        /// <summary>
        /// 购买商品信息
        /// </summary>
        [JsonPropertyName("item_order_details")]
        public List<ItemOrderDetail> ItemOrderDetails { get; set; }

        /// <summary>
        /// 商户订单号,64个字符以内、只能包含字母、数字、下划线；需保证在商户端不重复
        /// </summary>
        [JsonPropertyName("out_order_no")]
        public string OutOrderNo { get; set; }

        /// <summary>
        /// 商户传入营销信息，具体值要和口碑约定，格式为json格式
        /// </summary>
        [JsonPropertyName("promo_params")]
        public string PromoParams { get; set; }

        /// <summary>
        /// 门店ID
        /// </summary>
        [JsonPropertyName("shop_id")]
        public string ShopId { get; set; }

        /// <summary>
        /// 订单标题
        /// </summary>
        [JsonPropertyName("subject")]
        public string Subject { get; set; }

        /// <summary>
        /// 该笔订单允许的最晚付款时间，逾期将关闭交易，取值范围:1m～30m(单位:分钟) 不传默认3m。
        /// </summary>
        [JsonPropertyName("timeout")]
        public string Timeout { get; set; }

        /// <summary>
        /// 订单总金额，单位为元，精确到小数点后两位，必须等于费用之和
        /// </summary>
        [JsonPropertyName("total_amount")]
        public string TotalAmount { get; set; }
    }
}
