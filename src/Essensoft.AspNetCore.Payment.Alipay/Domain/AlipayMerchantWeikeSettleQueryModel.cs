using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayMerchantWeikeSettleQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMerchantWeikeSettleQueryModel : AlipayObject
    {
        /// <summary>
        /// 外部业务号
        /// </summary>
        [JsonProperty("out_biz_no")]
        public List<string> OutBizNo { get; set; }

        /// <summary>
        /// 分页查询页号，从1开始
        /// </summary>
        [JsonProperty("page_no")]
        public long PageNo { get; set; }

        /// <summary>
        /// 分页查询页大小，最大100
        /// </summary>
        [JsonProperty("page_size")]
        public long PageSize { get; set; }
    }
}
