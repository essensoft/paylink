using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Alipay.Domain
{
    /// <summary>
    /// AlipayEcoEntertainmentOrderUploadModel Data Structure.
    /// </summary>
    public class AlipayEcoEntertainmentOrderUploadModel : AlipayObject
    {
        /// <summary>
        /// 数娱充值ISV订单回流模型
        /// </summary>
        [JsonProperty("entertainment_order_info")]
        public EntertainmentOrderInfo EntertainmentOrderInfo { get; set; }
    }
}
