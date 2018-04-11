using System;
using Newtonsoft.Json;
using System.Xml.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// ProdParams Data Structure.
    /// </summary>
    [Serializable]
    public class ProdParams : AlipayObject
    {
        /// <summary>
        /// 预授权业务信息
        /// </summary>
        [JsonProperty("auth_biz_params")]
        [XmlElement("auth_biz_params")]
        public string AuthBizParams { get; set; }
    }
}
