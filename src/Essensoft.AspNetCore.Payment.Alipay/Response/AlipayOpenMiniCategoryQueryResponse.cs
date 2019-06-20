using System.Collections.Generic;
using Essensoft.AspNetCore.Payment.Alipay.Domain;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayOpenMiniCategoryQueryResponse.
    /// </summary>
    public class AlipayOpenMiniCategoryQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 小程序类目列表
        /// </summary>
        [JsonProperty("category_list")]
        public List<MiniAppCategory> CategoryList { get; set; }
    }
}
