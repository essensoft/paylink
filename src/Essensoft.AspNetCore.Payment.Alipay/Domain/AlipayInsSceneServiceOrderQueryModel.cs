using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayInsSceneServiceOrderQueryModel Data Structure.
    /// </summary>
    public class AlipayInsSceneServiceOrderQueryModel : AlipayObject
    {
        /// <summary>
        /// 服务订单号
        /// </summary>
        [JsonPropertyName("order_no")]
        public string OrderNo { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [JsonPropertyName("user_id")]
        public string UserId { get; set; }
    }
}
