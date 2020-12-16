using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayCommerceLogisticsOrderInstantdeliveryCreateModel Data Structure.
    /// </summary>
    public class AlipayCommerceLogisticsOrderInstantdeliveryCreateModel : AlipayObject
    {
        /// <summary>
        /// 消费者id， 如果consumer_source是alipay，则consumer_id必须是支付宝用户uid；如果consumer_source是wx，则consumer_id可以为空
        /// </summary>
        [JsonPropertyName("consumer_id")]
        public string ConsumerId { get; set; }

        /// <summary>
        /// 消费者通知明细
        /// </summary>
        [JsonPropertyName("consumer_notify")]
        public ConsumerNotifyIstd ConsumerNotify { get; set; }

        /// <summary>
        /// 消费者来源,支付宝：alipay; 微信：wx
        /// </summary>
        [JsonPropertyName("consumer_source")]
        public string ConsumerSource { get; set; }

        /// <summary>
        /// 商品明细
        /// </summary>
        [JsonPropertyName("goods_details")]
        public List<GoodsDetailIstd> GoodsDetails { get; set; }

        /// <summary>
        /// 商品汇总信息
        /// </summary>
        [JsonPropertyName("goods_info")]
        public GoodsInfoIstd GoodsInfo { get; set; }

        /// <summary>
        /// 即时配送公司编码
        /// </summary>
        [JsonPropertyName("logistics_code")]
        public string LogisticsCode { get; set; }

        /// <summary>
        /// 下即时配送订单token, 配送公司可以返回此字段，当商家下单时候带上这个字段，保证在一段时间内运费不变
        /// </summary>
        [JsonPropertyName("logistics_token")]
        public string LogisticsToken { get; set; }

        /// <summary>
        /// 即时配送订单扩展
        /// </summary>
        [JsonPropertyName("order_ext_istd")]
        public OrderExtIstd OrderExtIstd { get; set; }

        /// <summary>
        /// 商家订单号
        /// </summary>
        [JsonPropertyName("out_order_no")]
        public string OutOrderNo { get; set; }

        /// <summary>
        /// 收件人
        /// </summary>
        [JsonPropertyName("receiver")]
        public ReceiverIstd Receiver { get; set; }

        /// <summary>
        /// 发件人
        /// </summary>
        [JsonPropertyName("sender")]
        public SenderIstd Sender { get; set; }

        /// <summary>
        /// 商家门店编号
        /// </summary>
        [JsonPropertyName("shop_no")]
        public string ShopNo { get; set; }
    }
}
