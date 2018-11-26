using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// SsdataFindataOperatorUserinfoCertifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class SsdataFindataOperatorUserinfoCertifyModel : AlipayObject
    {
        /// <summary>
        /// 业务流水号，提交用户信息时系统返回
        /// </summary>
        [JsonProperty("biz_no")]
        [XmlElement("biz_no")]
        public string BizNo { get; set; }

        /// <summary>
        /// 用户运营商登录信息
        /// </summary>
        [JsonProperty("form_map")]
        [XmlElement("form_map")]
        public LoginForm FormMap { get; set; }
    }
}
