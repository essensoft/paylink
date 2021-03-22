using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// TransferUserName Data Structure.
    /// </summary>
    public class TransferUserName : AlipayObject
    {
        /// <summary>
        /// 姓
        /// </summary>
        [JsonPropertyName("first_name")]
        public string FirstName { get; set; }

        /// <summary>
        /// 全名
        /// </summary>
        [JsonPropertyName("full_name")]
        public string FullName { get; set; }

        /// <summary>
        /// 名
        /// </summary>
        [JsonPropertyName("last_name")]
        public string LastName { get; set; }

        /// <summary>
        /// 中间名字
        /// </summary>
        [JsonPropertyName("middle_name")]
        public string MiddleName { get; set; }

        /// <summary>
        /// 本地名字
        /// </summary>
        [JsonPropertyName("native_name")]
        public string NativeName { get; set; }
    }
}
