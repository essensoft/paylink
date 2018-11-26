using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayInsAutoCarSaveResponse.
    /// </summary>
    public class AlipayInsAutoCarSaveResponse : AlipayResponse
    {
        /// <summary>
        /// 车牌号
        /// </summary>
        [JsonProperty("car_no")]
        [XmlElement("car_no")]
        public string CarNo { get; set; }
    }
}
