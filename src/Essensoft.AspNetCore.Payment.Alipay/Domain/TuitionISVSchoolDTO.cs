using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// TuitionISVSchoolDTO Data Structure.
    /// </summary>
    public class TuitionISVSchoolDTO : AlipayObject
    {
        /// <summary>
        /// 2位国家码
        /// </summary>
        [JsonPropertyName("country")]
        public string Country { get; set; }

        /// <summary>
        /// 学校id
        /// </summary>
        [JsonPropertyName("school_id")]
        public string SchoolId { get; set; }

        /// <summary>
        /// 学校名称
        /// </summary>
        [JsonPropertyName("school_name")]
        public string SchoolName { get; set; }
    }
}
