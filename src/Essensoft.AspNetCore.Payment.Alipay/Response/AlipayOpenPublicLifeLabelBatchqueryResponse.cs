using Newtonsoft.Json;
using System.Xml.Serialization;
using System.Collections.Generic;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayOpenPublicLifeLabelBatchqueryResponse.
    /// </summary>
    public class AlipayOpenPublicLifeLabelBatchqueryResponse : AlipayResponse
    {
        /// <summary>
        /// 标签列表
        /// </summary>
        [JsonProperty("labels")]
        [XmlArray("labels")]
        [XmlArrayItem("life_label")]
        public List<LifeLabel> Labels { get; set; }
    }
}
