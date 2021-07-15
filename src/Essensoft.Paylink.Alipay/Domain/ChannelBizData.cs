using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// ChannelBizData Data Structure.
    /// </summary>
    public class ChannelBizData : AlipayObject
    {
        /// <summary>
        /// 商品描述
        /// </summary>
        [JsonPropertyName("goods_info")]
        public string GoodsInfo { get; set; }

        /// <summary>
        /// 订单信息详情
        /// </summary>
        [JsonPropertyName("order_info")]
        public string OrderInfo { get; set; }

        /// <summary>
        /// 渠道订单号
        /// </summary>
        [JsonPropertyName("order_no")]
        public string OrderNo { get; set; }

        /// <summary>
        /// 价格因子
        /// </summary>
        [JsonPropertyName("premium_factor")]
        public string PremiumFactor { get; set; }
    }
}
