using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayMarketingDataModelBatchqueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMarketingDataModelBatchqueryModel : AlipayObject
    {
        /// <summary>
        /// 当前页面。输入参数值为模型页数，一页最多30条；用于查询模型清单
        /// </summary>
        [JsonProperty("page")]
        public string Page { get; set; }

        /// <summary>
        /// 每页最大条数。输入参数值为模型页面展现条数，最多展现30条；用于查询模型清单条数
        /// </summary>
        [JsonProperty("size")]
        public string Size { get; set; }
    }
}
