using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayInsDataDsbEstimateQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayInsDataDsbEstimateQueryModel : AlipayObject
    {
        /// <summary>
        /// 定损单号
        /// </summary>
        [JsonProperty("estimate_no")]
        [XmlElement("estimate_no")]
        public string EstimateNo { get; set; }

        /// <summary>
        /// 车架号
        /// </summary>
        [JsonProperty("frame_no")]
        [XmlElement("frame_no")]
        public string FrameNo { get; set; }

        /// <summary>
        /// 车牌号
        /// </summary>
        [JsonProperty("license_no")]
        [XmlElement("license_no")]
        public string LicenseNo { get; set; }
    }
}
