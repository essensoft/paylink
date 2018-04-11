using System;
using Newtonsoft.Json;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// ZhimaMerchantTestPracticeModel Data Structure.
    /// </summary>
    [Serializable]
    public class ZhimaMerchantTestPracticeModel : AlipayObject
    {
        /// <summary>
        /// a d
        /// </summary>
        [JsonProperty("add")]
        [XmlArray("add")]
        [XmlArrayItem("string")]
        public List<string> Add { get; set; }

        /// <summary>
        /// zzz
        /// </summary>
        [JsonProperty("xxxx")]
        [XmlElement("xxxx")]
        public XXXXsdasdasd Xxxx { get; set; }
    }
}
