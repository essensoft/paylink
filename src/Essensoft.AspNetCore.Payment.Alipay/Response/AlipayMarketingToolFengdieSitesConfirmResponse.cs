using System.Xml.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayMarketingToolFengdieSitesConfirmResponse.
    /// </summary>
    public class AlipayMarketingToolFengdieSitesConfirmResponse : AlipayResponse
    {
        /// <summary>
        /// 返回执行云凤蝶站点审核操作的成功失败状态
        /// </summary>
        [JsonProperty("data")]
        [XmlElement("data")]
        public FengdieSuccessRespModel Data { get; set; }
    }
}
