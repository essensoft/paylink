using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// UserName Data Structure.
    /// </summary>
    public class UserName : AlipayObject
    {
        /// <summary>
        /// User's first name
        /// </summary>
        [JsonPropertyName("first_name")]
        public string FirstName { get; set; }

        /// <summary>
        /// User's full name
        /// </summary>
        [JsonPropertyName("full_name")]
        public string FullName { get; set; }

        /// <summary>
        /// User's last name
        /// </summary>
        [JsonPropertyName("last_name")]
        public string LastName { get; set; }

        /// <summary>
        /// User's middle name
        /// </summary>
        [JsonPropertyName("middle_name")]
        public string MiddleName { get; set; }
    }
}
