using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayUserAntarchiveCustrelationAddModel Data Structure.
    /// </summary>
    public class AlipayUserAntarchiveCustrelationAddModel : AlipayObject
    {
        /// <summary>
        /// 待关联客户id
        /// </summary>
        [JsonPropertyName("cust_id")]
        public string CustId { get; set; }

        /// <summary>
        /// 蚂蚁档案身份信息证明
        /// </summary>
        [JsonPropertyName("identity_certificate")]
        public AntArchiveIdentityCertificate IdentityCertificate { get; set; }
    }
}
