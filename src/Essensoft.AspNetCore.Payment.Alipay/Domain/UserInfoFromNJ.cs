using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// UserInfoFromNJ Data Structure.
    /// </summary>
    public class UserInfoFromNJ : AlipayObject
    {
        /// <summary>
        /// 姓名
        /// </summary>
        [JsonPropertyName("company")]
        public string Company { get; set; }

        /// <summary>
        /// 电话
        /// </summary>
        [JsonPropertyName("tel")]
        public string Tel { get; set; }
    }
}
