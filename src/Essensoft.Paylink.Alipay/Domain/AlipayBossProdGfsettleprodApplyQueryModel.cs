using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// AlipayBossProdGfsettleprodApplyQueryModel Data Structure.
    /// </summary>
    public class AlipayBossProdGfsettleprodApplyQueryModel : AlipayObject
    {
        /// <summary>
        /// 合约号，等同于集采PO号
        /// </summary>
        [JsonPropertyName("arrangement_no")]
        public string ArrangementNo { get; set; }

        /// <summary>
        /// 供应商支付宝2088账号
        /// </summary>
        [JsonPropertyName("ip_role_id")]
        public string IpRoleId { get; set; }
    }
}
