using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayCommerceTransportAdStocktaskBatchqueryModel Data Structure.
    /// </summary>
    public class AlipayCommerceTransportAdStocktaskBatchqueryModel : AlipayObject
    {
        /// <summary>
        /// 用户id+根据用户id批量查询该用户提交的库存查询任务
        /// </summary>
        [JsonPropertyName("ad_user_id")]
        public long AdUserId { get; set; }
    }
}
