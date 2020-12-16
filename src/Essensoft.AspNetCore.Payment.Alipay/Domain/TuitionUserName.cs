using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// TuitionUserName Data Structure.
    /// </summary>
    public class TuitionUserName : AlipayObject
    {
        /// <summary>
        /// 姓名姓氏
        /// </summary>
        [JsonPropertyName("first_name")]
        public string FirstName { get; set; }

        /// <summary>
        /// 完整姓名
        /// </summary>
        [JsonPropertyName("full_name")]
        public string FullName { get; set; }

        /// <summary>
        /// 姓名最后的名字
        /// </summary>
        [JsonPropertyName("last_name")]
        public string LastName { get; set; }

        /// <summary>
        /// 姓名中间的名字
        /// </summary>
        [JsonPropertyName("middle_name")]
        public string MiddleName { get; set; }
    }
}
