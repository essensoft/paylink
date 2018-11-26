using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayOpenPublicLifeAgentcreateQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenPublicLifeAgentcreateQueryModel : AlipayObject
    {
        /// <summary>
        /// 由开发者创建的外部入驻申请单据号
        /// </summary>
        [JsonProperty("out_biz_no")]
        [XmlElement("out_biz_no")]
        public string OutBizNo { get; set; }
    }
}
