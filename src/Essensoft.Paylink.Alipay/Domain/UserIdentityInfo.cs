using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// UserIdentityInfo Data Structure.
    /// </summary>
    public class UserIdentityInfo : AlipayObject
    {
        /// <summary>
        /// 校园码身份信息
        /// </summary>
        [JsonPropertyName("h_school_info")]
        public HSchoolInfo HSchoolInfo { get; set; }
    }
}
