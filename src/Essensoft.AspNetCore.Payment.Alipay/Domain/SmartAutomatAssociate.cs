using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// SmartAutomatAssociate Data Structure.
    /// </summary>
    [Serializable]
    public class SmartAutomatAssociate : AlipayObject
    {
        /// <summary>
        /// 合作伙伴类型  DISTRIBUTORS:渠道商
        /// </summary>
        [JsonProperty("associate_type")]
        [XmlElement("associate_type")]
        public string AssociateType { get; set; }

        /// <summary>
        /// 合作伙伴的支付宝账号ID
        /// </summary>
        [JsonProperty("associate_user_id")]
        [XmlElement("associate_user_id")]
        public string AssociateUserId { get; set; }
    }
}
