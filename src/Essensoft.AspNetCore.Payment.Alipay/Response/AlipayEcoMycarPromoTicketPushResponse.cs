using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayEcoMycarPromoTicketPushResponse.
    /// </summary>
    public class AlipayEcoMycarPromoTicketPushResponse : AlipayResponse
    {
        /// <summary>
        /// 处理结果返回码
        /// </summary>
        [JsonProperty("sp_apply_no")]
        [XmlElement("sp_apply_no")]
        public string SpApplyNo { get; set; }
    }
}
