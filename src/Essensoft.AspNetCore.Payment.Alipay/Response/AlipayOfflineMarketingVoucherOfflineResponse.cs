using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayOfflineMarketingVoucherOfflineResponse.
    /// </summary>
    public class AlipayOfflineMarketingVoucherOfflineResponse : AlipayResponse
    {
        /// <summary>
        /// 券模板编号
        /// </summary>
        [JsonProperty("voucher_id")]
        [XmlElement("voucher_id")]
        public string VoucherId { get; set; }

        /// <summary>
        /// 券模板状态。EFFECTIVE=生效，INVALID=失效。
        /// </summary>
        [JsonProperty("voucher_status")]
        [XmlElement("voucher_status")]
        public string VoucherStatus { get; set; }
    }
}
