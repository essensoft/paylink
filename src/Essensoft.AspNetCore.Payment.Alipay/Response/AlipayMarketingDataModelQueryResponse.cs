using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayMarketingDataModelQueryResponse.
    /// </summary>
    public class AlipayMarketingDataModelQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 模型数据。此为参数列表，输出参数为模型字段及模型结果值; 用于数据实验室算法模型对外输出  alias:列别名。此为模型字段  data:列值。此为模型数值
        /// </summary>
        [JsonPropertyName("model_column")]
        public List<ModelColumn> ModelColumn { get; set; }
    }
}
