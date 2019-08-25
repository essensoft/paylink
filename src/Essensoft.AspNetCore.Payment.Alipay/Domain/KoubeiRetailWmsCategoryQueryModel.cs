using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KoubeiRetailWmsCategoryQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiRetailWmsCategoryQueryModel : AlipayObject
    {
        /// <summary>
        /// 根据类目ID查询
        /// </summary>
        [JsonProperty("category_id")]
        public string CategoryId { get; set; }

        /// <summary>
        /// 操作上下文
        /// </summary>
        [JsonProperty("operate_context")]
        public OperateContext OperateContext { get; set; }
    }
}
