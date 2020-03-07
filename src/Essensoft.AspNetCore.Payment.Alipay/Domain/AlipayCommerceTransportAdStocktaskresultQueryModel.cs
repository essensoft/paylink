using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayCommerceTransportAdStocktaskresultQueryModel Data Structure.
    /// </summary>
    public class AlipayCommerceTransportAdStocktaskresultQueryModel : AlipayObject
    {
        /// <summary>
        /// 广告主id + 库存结果查询前校验该任务是否属于该广告主
        /// </summary>
        [JsonPropertyName("ad_user_id")]
        public long AdUserId { get; set; }

        /// <summary>
        /// 库存查询任务id + 根据库存查询任务id获得库存结果
        /// </summary>
        [JsonPropertyName("task_id")]
        public long TaskId { get; set; }
    }
}
