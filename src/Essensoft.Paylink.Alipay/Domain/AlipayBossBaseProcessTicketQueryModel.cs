using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// AlipayBossBaseProcessTicketQueryModel Data Structure.
    /// </summary>
    public class AlipayBossBaseProcessTicketQueryModel : AlipayObject
    {
        /// <summary>
        /// 流程实例Id
        /// </summary>
        [JsonPropertyName("puid")]
        public string Puid { get; set; }
    }
}
