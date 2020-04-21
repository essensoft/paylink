using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// KoubeiTradeOrderEnterpriseQueryResponse.
    /// </summary>
    public class KoubeiTradeOrderEnterpriseQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 订单下单主体id，一般是支付宝账号，也可能是虚拟账号
        /// </summary>
        [JsonPropertyName("buyer_user_id")]
        public string BuyerUserId { get; set; }

        /// <summary>
        /// json格式的字符串，订单的扩展信息
        /// </summary>
        [JsonPropertyName("ext_info")]
        public string ExtInfo { get; set; }

        /// <summary>
        /// 订单对应的商家补贴的金额
        /// </summary>
        [JsonPropertyName("merchant_subsidy_amount")]
        public string MerchantSubsidyAmount { get; set; }

        /// <summary>
        /// 口碑订单号
        /// </summary>
        [JsonPropertyName("order_no")]
        public string OrderNo { get; set; }

        /// <summary>
        /// 订单产品码
        /// </summary>
        [JsonPropertyName("order_product")]
        public string OrderProduct { get; set; }

        /// <summary>
        /// 商户订单号
        /// </summary>
        [JsonPropertyName("out_order_no")]
        public string OutOrderNo { get; set; }

        /// <summary>
        /// 商户签约支付宝账号
        /// </summary>
        [JsonPropertyName("partner_id")]
        public string PartnerId { get; set; }

        /// <summary>
        /// 订单支付的实际资金
        /// </summary>
        [JsonPropertyName("real_amount")]
        public string RealAmount { get; set; }

        /// <summary>
        /// 订单打款对应的商家收款账户
        /// </summary>
        [JsonPropertyName("seller_id")]
        public string SellerId { get; set; }

        /// <summary>
        /// 口碑门店id
        /// </summary>
        [JsonPropertyName("shop_id")]
        public string ShopId { get; set; }

        /// <summary>
        /// 订单状态:INITIAL（订单初始化）、WAIT_PAY（订单已创建待支付）、ERROR（订单异常）、PAID（已支付）、SUCCESS（订单成功）、WAIT_PAY_CLOSE（订单未支付后自动关闭或者未支付用户主动关闭）、CLOSED（订单支付成功后，全部退款）、FINISH（订完完结）
        /// </summary>
        [JsonPropertyName("status")]
        public string Status { get; set; }

        /// <summary>
        /// 订单标题
        /// </summary>
        [JsonPropertyName("subject")]
        public string Subject { get; set; }

        /// <summary>
        /// 订单对应的平台补贴的金额
        /// </summary>
        [JsonPropertyName("subsidy_amount")]
        public string SubsidyAmount { get; set; }

        /// <summary>
        /// 订单总金额
        /// </summary>
        [JsonPropertyName("total_amount")]
        public string TotalAmount { get; set; }
    }
}
