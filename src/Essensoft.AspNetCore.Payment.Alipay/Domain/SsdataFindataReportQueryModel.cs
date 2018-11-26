using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// SsdataFindataReportQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class SsdataFindataReportQueryModel : AlipayObject
    {
        /// <summary>
        /// 商户在调用产品的第一个接口时系统返回的业务流水号
        /// </summary>
        [JsonProperty("biz_no")]
        [XmlElement("biz_no")]
        public string BizNo { get; set; }
    }
}
