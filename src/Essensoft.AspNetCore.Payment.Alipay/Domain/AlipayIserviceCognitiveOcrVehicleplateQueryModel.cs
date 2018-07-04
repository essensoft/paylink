using System;
using Newtonsoft.Json;
using System.Xml.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayIserviceCognitiveOcrVehicleplateQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayIserviceCognitiveOcrVehicleplateQueryModel : AlipayObject
    {
        /// <summary>
        /// 车牌图片base64加密后内容
        /// </summary>
        [JsonProperty("image_content")]
        [XmlElement("image_content")]
        public string ImageContent { get; set; }
    }
}
