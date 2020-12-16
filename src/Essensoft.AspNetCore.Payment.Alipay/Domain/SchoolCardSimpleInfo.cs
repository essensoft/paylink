using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// SchoolCardSimpleInfo Data Structure.
    /// </summary>
    public class SchoolCardSimpleInfo : AlipayObject
    {
        /// <summary>
        /// 支付宝学校编码
        /// </summary>
        [JsonPropertyName("school_id")]
        public string SchoolId { get; set; }

        /// <summary>
        /// 学校名称
        /// </summary>
        [JsonPropertyName("school_name")]
        public string SchoolName { get; set; }

        /// <summary>
        /// 学校标识码
        /// </summary>
        [JsonPropertyName("school_stdcode")]
        public string SchoolStdcode { get; set; }

        /// <summary>
        /// isv分配的学生短码
        /// </summary>
        [JsonPropertyName("short_code")]
        public string ShortCode { get; set; }

        /// <summary>
        /// 支付宝校园卡状态，0:有效，1:无效
        /// </summary>
        [JsonPropertyName("status")]
        public string Status { get; set; }
    }
}
