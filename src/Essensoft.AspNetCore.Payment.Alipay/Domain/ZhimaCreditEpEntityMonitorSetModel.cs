using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// ZhimaCreditEpEntityMonitorSetModel Data Structure.
    /// </summary>
    public class ZhimaCreditEpEntityMonitorSetModel : AlipayObject
    {
        /// <summary>
        /// 联系人列表
        /// </summary>
        [JsonPropertyName("contact_list")]
        public string ContactList { get; set; }

        /// <summary>
        /// 方案ID
        /// </summary>
        [JsonPropertyName("solution_id")]
        public string SolutionId { get; set; }
    }
}
