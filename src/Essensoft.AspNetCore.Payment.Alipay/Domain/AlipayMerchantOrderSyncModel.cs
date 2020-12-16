using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayMerchantOrderSyncModel Data Structure.
    /// </summary>
    public class AlipayMerchantOrderSyncModel : AlipayObject
    {
        /// <summary>
        /// 订单金额，单位为元
        /// </summary>
        [JsonPropertyName("amount")]
        public string Amount { get; set; }

        /// <summary>
        /// 买家userId
        /// </summary>
        [JsonPropertyName("buyer_id")]
        public string BuyerId { get; set; }

        /// <summary>
        /// buyer_info与buyer_user_id必选其一
        /// </summary>
        [JsonPropertyName("buyer_info")]
        public UserInfomation BuyerInfo { get; set; }

        /// <summary>
        /// 优惠金额
        /// </summary>
        [JsonPropertyName("discount_amount")]
        public string DiscountAmount { get; set; }

        /// <summary>
        /// 扩展信息，请参见产品文档
        /// </summary>
        [JsonPropertyName("ext_info")]
        public List<OrderExtInfo> ExtInfo { get; set; }

        /// <summary>
        /// 商品信息列表
        /// </summary>
        [JsonPropertyName("item_order_list")]
        public List<ItemOrderInfo> ItemOrderList { get; set; }

        /// <summary>
        /// 物流信息  列表最多支持物流信息个数，请参考产品文档  注：若该值不为空，且物流信息同步至我的快递，则在查询订单时可返回具体物流信息
        /// </summary>
        [JsonPropertyName("logistics_info_list")]
        public List<OrderLogisticsInformationRequest> LogisticsInfoList { get; set; }

        /// <summary>
        /// 订单授权码(与订单一一对应，不是请求维度的，服务订单首次同步必传） 利用订单同步前获取的formId作为订单授权码。订单授权码对应的小程序id与买家uid与同步订单的小程序id和买家uid一致 注：当order_type为SERVICE_ORDER时必填
        /// </summary>
        [JsonPropertyName("order_auth_code")]
        public string OrderAuthCode { get; set; }

        /// <summary>
        /// 订单创建时间 当order_type为SERVICE_ORDER时必传
        /// </summary>
        [JsonPropertyName("order_create_time")]
        public string OrderCreateTime { get; set; }

        /// <summary>
        /// 订单支付时间 当pay_channel为非ALIPAY时，且订单状态已流转到“支付”或支付后时，需要将支付时间传入
        /// </summary>
        [JsonPropertyName("order_pay_time")]
        public string OrderPayTime { get; set; }

        /// <summary>
        /// 订单类型，若为空，默认为交易订单，每次请求必传 -SERVICE_ORDER：服务订单 -TRADE_ORDER：交易订单
        /// </summary>
        [JsonPropertyName("order_type")]
        public string OrderType { get; set; }

        /// <summary>
        /// 外部订单号 out_biz_no唯一对应一笔订单，相同的订单需传入相同的out_biz_no
        /// </summary>
        [JsonPropertyName("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 交易对应的签约商户userId 注意：该字段自2020-02-16日起，可以不传入
        /// </summary>
        [JsonPropertyName("partner_id")]
        public string PartnerId { get; set; }

        /// <summary>
        /// 支付金额 需要实际支付的金额
        /// </summary>
        [JsonPropertyName("pay_amount")]
        public string PayAmount { get; set; }

        /// <summary>
        /// 支付超时时间，超过时间支付宝自行关闭订单
        /// </summary>
        [JsonPropertyName("pay_timeout_express")]
        public string PayTimeoutExpress { get; set; }

        /// <summary>
        /// 商户订单同步记录id
        /// </summary>
        [JsonPropertyName("record_id")]
        public string RecordId { get; set; }

        /// <summary>
        /// 卖家userId 注意：该字段自2020-02-16日起，可以不传入
        /// </summary>
        [JsonPropertyName("seller_id")]
        public string SellerId { get; set; }

        /// <summary>
        /// 是否需要小程序订单代理发送模版消息，Y代表需要发送，N代表不需要发送，不传默认不发送
        /// </summary>
        [JsonPropertyName("send_msg")]
        public string SendMsg { get; set; }

        /// <summary>
        /// 门店信息
        /// </summary>
        [JsonPropertyName("shop_info")]
        public OrderShopInfo ShopInfo { get; set; }

        /// <summary>
        /// 凭证信息
        /// </summary>
        [JsonPropertyName("ticket_info")]
        public TicketInfo TicketInfo { get; set; }

        /// <summary>
        /// 订单所对应的支付宝交易号
        /// </summary>
        [JsonPropertyName("trade_no")]
        public string TradeNo { get; set; }

        /// <summary>
        /// 交易号类型 1. TRADE-交易，为空默认为TRADE 2. TRANSFER-转账 3. ENTRUST-受托
        /// </summary>
        [JsonPropertyName("trade_type")]
        public string TradeType { get; set; }
    }
}
