using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayMarketingCampaignDrawcampStatusUpdateResponse.
    /// </summary>
    public class AlipayMarketingCampaignDrawcampStatusUpdateResponse : AlipayResponse
    {
        /// <summary>
        /// 修改状态操作结果状态，业务维度，网关返回成功状态码并且业务维度返回true才成功
        /// </summary>
        [JsonProperty("camp_result")]
        [XmlElement("camp_result")]
        public bool CampResult { get; set; }
    }
}
