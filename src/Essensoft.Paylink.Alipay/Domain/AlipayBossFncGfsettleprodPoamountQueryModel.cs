using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// AlipayBossFncGfsettleprodPoamountQueryModel Data Structure.
    /// </summary>
    public class AlipayBossFncGfsettleprodPoamountQueryModel : AlipayObject
    {
        /// <summary>
        /// PO号
        /// </summary>
        [JsonPropertyName("arrangement_no")]
        public string ArrangementNo { get; set; }

        /// <summary>
        /// 供应商蚂蚁2088账号PID
        /// </summary>
        [JsonPropertyName("ip_role_id")]
        public string IpRoleId { get; set; }
    }
}
