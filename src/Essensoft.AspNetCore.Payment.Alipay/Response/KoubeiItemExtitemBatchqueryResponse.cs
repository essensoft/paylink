using System.Collections.Generic;
using Essensoft.AspNetCore.Payment.Alipay.Domain;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// KoubeiItemExtitemBatchqueryResponse.
    /// </summary>
    public class KoubeiItemExtitemBatchqueryResponse : AlipayResponse
    {
        /// <summary>
        /// 商品信息列表
        /// </summary>
        [JsonProperty("model_list")]
        public List<ExtItem> ModelList { get; set; }

        /// <summary>
        /// 当前页码
        /// </summary>
        [JsonProperty("page_num")]
        public string PageNum { get; set; }

        /// <summary>
        /// 分页大小
        /// </summary>
        [JsonProperty("page_size")]
        public string PageSize { get; set; }

        /// <summary>
        /// 总记录数
        /// </summary>
        [JsonProperty("total_size")]
        public string TotalSize { get; set; }
    }
}
