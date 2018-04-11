using Newtonsoft.Json;
using System.Xml.Serialization;
using System.Collections.Generic;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayOpenMiniVersionListQueryResponse.
    /// </summary>
    public class AlipayOpenMiniVersionListQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 小程序的版本号列表
        /// </summary>
        [JsonProperty("app_versions")]
        [XmlArray("app_versions")]
        [XmlArrayItem("string")]
        public List<string> AppVersions { get; set; }
    }
}
