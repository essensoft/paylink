using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayMarketingDataModelBatchqueryResponse.
    /// </summary>
    public class AlipayMarketingDataModelBatchqueryResponse : AlipayResponse
    {
        /// <summary>
        /// 模型列表信息。此为参数列表，输出参数为模型名称、模型描述、模型唯一查询标识符及查询参数; 用于数据实验室算法模型清单输出  model_name:模型名称。此为输出模型在数据实验室的名称  model_desc:模型描述。此为客户对输出模型功能描述  model_uk:模型唯一查询标识符。用于标识模型的唯一性  query_key:查询参数。此为查询外部用户身份信息类型
        /// </summary>
        [JsonPropertyName("model_meta")]
        public List<ModelMeta> ModelMeta { get; set; }

        /// <summary>
        /// 模型总页数。输出参数值为客户制作总模型数；用于查询模型数总量
        /// </summary>
        [JsonPropertyName("total_page_count")]
        public string TotalPageCount { get; set; }
    }
}
