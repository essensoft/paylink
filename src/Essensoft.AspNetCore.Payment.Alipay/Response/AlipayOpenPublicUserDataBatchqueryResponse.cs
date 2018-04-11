using Newtonsoft.Json;
using System.Xml.Serialization;
using System.Collections.Generic;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayOpenPublicUserDataBatchqueryResponse.
    /// </summary>
    public class AlipayOpenPublicUserDataBatchqueryResponse : AlipayResponse
    {
        /// <summary>
        /// 用户分析数据
        /// </summary>
        [JsonProperty("data_list")]
        [XmlArray("data_list")]
        [XmlArrayItem("user_analysis_data")]
        public List<UserAnalysisData> DataList { get; set; }
    }
}
