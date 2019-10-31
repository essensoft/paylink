using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayOpenMiniPlanOperateBatchqueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenMiniPlanOperateBatchqueryModel : AlipayObject
    {
        /// <summary>
        /// 页码数，从第一页开始
        /// </summary>
        [JsonProperty("page_num")]
        public long PageNum { get; set; }

        /// <summary>
        /// 每页记录数，默认10
        /// </summary>
        [JsonProperty("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 投放方案场景码，目前只支持支付后推荐场景：PAYMENT_SUCCESS
        /// </summary>
        [JsonProperty("scene")]
        public string Scene { get; set; }
    }
}
