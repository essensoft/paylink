using System;
using Newtonsoft.Json;
using System.Xml.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayEcoRenthouseRenterZhimaQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEcoRenthouseRenterZhimaQueryModel : AlipayObject
    {
        /// <summary>
        /// 身份证号
        /// </summary>
        [JsonProperty("card_no")]
        [XmlElement("card_no")]
        public string CardNo { get; set; }

        /// <summary>
        /// 用户姓名
        /// </summary>
        [JsonProperty("user_name")]
        [XmlElement("user_name")]
        public string UserName { get; set; }
    }
}
