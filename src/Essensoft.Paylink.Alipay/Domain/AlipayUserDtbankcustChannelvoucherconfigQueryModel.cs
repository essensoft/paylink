using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// AlipayUserDtbankcustChannelvoucherconfigQueryModel Data Structure.
    /// </summary>
    public class AlipayUserDtbankcustChannelvoucherconfigQueryModel : AlipayObject
    {
        /// <summary>
        /// 在开放活动平台配置活动的唯一id，唯一标志一个活动
        /// </summary>
        [JsonPropertyName("activity_id")]
        public string ActivityId { get; set; }
    }
}
