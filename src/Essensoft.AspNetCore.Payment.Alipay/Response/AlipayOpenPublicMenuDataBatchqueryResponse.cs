using Newtonsoft.Json;
using System.Xml.Serialization;
using System.Collections.Generic;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayOpenPublicMenuDataBatchqueryResponse.
    /// </summary>
    public class AlipayOpenPublicMenuDataBatchqueryResponse : AlipayResponse
    {
        /// <summary>
        /// 菜单分析数据列表
        /// </summary>
        [JsonProperty("data_list")]
        [XmlArray("data_list")]
        [XmlArrayItem("menu_analysis_data")]
        public List<MenuAnalysisData> DataList { get; set; }
    }
}
