using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.Paylink.Alipay.Domain;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// AlipayDataDataserviceAdDataQueryResponse.
    /// </summary>
    public class AlipayDataDataserviceAdDataQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 汇总结果数据列表
        /// </summary>
        [JsonPropertyName("data_list")]
        public List<DataDetail> DataList { get; set; }
    }
}
