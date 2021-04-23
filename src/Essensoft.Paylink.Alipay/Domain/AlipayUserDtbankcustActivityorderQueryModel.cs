using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// AlipayUserDtbankcustActivityorderQueryModel Data Structure.
    /// </summary>
    public class AlipayUserDtbankcustActivityorderQueryModel : AlipayObject
    {
        /// <summary>
        /// 活动流水唯一id，由系统自动生成的，在调用活动触发接口会返回该id。
        /// </summary>
        [JsonPropertyName("activity_order_id")]
        public string ActivityOrderId { get; set; }
    }
}
