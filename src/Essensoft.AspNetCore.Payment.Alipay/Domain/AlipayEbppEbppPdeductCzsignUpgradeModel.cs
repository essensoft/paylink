using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayEbppEbppPdeductCzsignUpgradeModel Data Structure.
    /// </summary>
    public class AlipayEbppEbppPdeductCzsignUpgradeModel : AlipayObject
    {
        /// <summary>
        /// 行业代扣协议ID
        /// </summary>
        [JsonPropertyName("agreement_id")]
        public string AgreementId { get; set; }

        /// <summary>
        /// 机构PID
        /// </summary>
        [JsonPropertyName("pid")]
        public string Pid { get; set; }
    }
}
