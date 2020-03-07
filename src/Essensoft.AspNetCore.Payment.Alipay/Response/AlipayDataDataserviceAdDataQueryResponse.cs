using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
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
