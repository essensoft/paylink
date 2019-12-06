using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayUserCustIdentifyActivity Data Structure.
    /// </summary>
    public class AlipayUserCustIdentifyActivity : AlipayObject
    {
        /// <summary>
        /// 活动扩展信息，预留字段。例如通过连接引导参加运营活动，包含活动链接（或者参与方式）及活动信息。
        /// </summary>
        [JsonPropertyName("activity_info")]
        public string ActivityInfo { get; set; }

        /// <summary>
        /// 活动名称
        /// </summary>
        [JsonPropertyName("activity_name")]
        public string ActivityName { get; set; }
    }
}
