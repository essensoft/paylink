using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// SsdataFindataOperatorSmsQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class SsdataFindataOperatorSmsQueryModel : AlipayObject
    {
        /// <summary>
        /// 系统的业务流水号，在调用提交用户信息时得到的biz_no
        /// </summary>
        [JsonProperty("biz_no")]
        [XmlElement("biz_no")]
        public string BizNo { get; set; }
    }
}
