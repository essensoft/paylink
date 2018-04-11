using System;
using Newtonsoft.Json;
using System.Xml.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayInsAutoCarSaveModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayInsAutoCarSaveModel : AlipayObject
    {
        /// <summary>
        /// 车牌号
        /// </summary>
        [JsonProperty("car_no")]
        [XmlElement("car_no")]
        public string CarNo { get; set; }

        /// <summary>
        /// 用户ID,车主会员ID
        /// </summary>
        [JsonProperty("user_id")]
        [XmlElement("user_id")]
        public string UserId { get; set; }
    }
}
