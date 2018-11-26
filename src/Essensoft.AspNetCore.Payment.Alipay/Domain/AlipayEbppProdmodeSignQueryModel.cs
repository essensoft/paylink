using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayEbppProdmodeSignQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEbppProdmodeSignQueryModel : AlipayObject
    {
        /// <summary>
        /// 出账/销账机构支付宝账号
        /// </summary>
        [JsonProperty("logon_id")]
        [XmlElement("logon_id")]
        public string LogonId { get; set; }

        /// <summary>
        /// 产品编号
        /// </summary>
        [JsonProperty("prod_code")]
        [XmlElement("prod_code")]
        public string ProdCode { get; set; }
    }
}
