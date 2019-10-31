using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayFinanceQuotationFindataSendModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayFinanceQuotationFindataSendModel : AlipayObject
    {
        /// <summary>
        /// 业务类型。strategy_pool策略池,strategy_pool_detail策略池明细
        /// </summary>
        [JsonProperty("biz_type")]
        public string BizType { get; set; }

        /// <summary>
        /// 机构发送给蚂蚁的业务数据。仅支持JSON
        /// </summary>
        [JsonProperty("content")]
        public string Content { get; set; }
    }
}
