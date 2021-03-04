using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// AlipayOverseasOpenSchoolQueryModel Data Structure.
    /// </summary>
    public class AlipayOverseasOpenSchoolQueryModel : AlipayObject
    {
        /// <summary>
        /// 学校名称
        /// </summary>
        [JsonPropertyName("school_name")]
        public string SchoolName { get; set; }
    }
}
