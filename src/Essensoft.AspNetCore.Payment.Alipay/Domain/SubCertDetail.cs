using System;
using Newtonsoft.Json;
using System.Xml.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// SubCertDetail Data Structure.
    /// </summary>
    [Serializable]
    public class SubCertDetail : AlipayObject
    {
        /// <summary>
        /// 凭证批次号
        /// </summary>
        [JsonProperty("lot_num")]
        [XmlElement("lot_num")]
        public string LotNum { get; set; }

        /// <summary>
        /// 子凭证有效点数
        /// </summary>
        [JsonProperty("lot_point")]
        [XmlElement("lot_point")]
        public string LotPoint { get; set; }

        /// <summary>
        /// 子凭证编号
        /// </summary>
        [JsonProperty("sub_lotnum")]
        [XmlElement("sub_lotnum")]
        public string SubLotnum { get; set; }
    }
}
