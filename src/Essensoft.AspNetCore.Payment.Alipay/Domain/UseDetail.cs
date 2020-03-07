using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// UseDetail Data Structure.
    /// </summary>
    public class UseDetail : AlipayObject
    {
        /// <summary>
        /// 实付金额，单位是分
        /// </summary>
        [JsonPropertyName("actual_amount")]
        public long ActualAmount { get; set; }

        /// <summary>
        /// 应付金额，单位是分
        /// </summary>
        [JsonPropertyName("amount")]
        public long Amount { get; set; }

        /// <summary>
        /// 权益使用的时间,格式yyyy-MM-dd HH:mm:ss (订单支付时间)
        /// </summary>
        [JsonPropertyName("date")]
        public string Date { get; set; }

        /// <summary>
        /// 使用的权益关联的商品信息
        /// </summary>
        [JsonPropertyName("goods_info")]
        public BenifitGoodsInfo GoodsInfo { get; set; }
    }
}
