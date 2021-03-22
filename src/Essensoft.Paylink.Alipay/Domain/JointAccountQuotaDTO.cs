using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// JointAccountQuotaDTO Data Structure.
    /// </summary>
    public class JointAccountQuotaDTO : AlipayObject
    {
        /// <summary>
        /// 额度维度
        /// </summary>
        [JsonPropertyName("quota_dimension")]
        public string QuotaDimension { get; set; }

        /// <summary>
        /// 协议额度
        /// </summary>
        [JsonPropertyName("quota_total")]
        public string QuotaTotal { get; set; }
    }
}
