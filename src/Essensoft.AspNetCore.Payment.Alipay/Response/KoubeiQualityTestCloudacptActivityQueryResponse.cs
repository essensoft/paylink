using Newtonsoft.Json;
using System.Xml.Serialization;
using System.Collections.Generic;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// KoubeiQualityTestCloudacptActivityQueryResponse.
    /// </summary>
    public class KoubeiQualityTestCloudacptActivityQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 活动列表
        /// </summary>
        [JsonProperty("activity_list")]
        [XmlArray("activity_list")]
        [XmlArrayItem("open_activity")]
        public List<OpenActivity> ActivityList { get; set; }
    }
}
