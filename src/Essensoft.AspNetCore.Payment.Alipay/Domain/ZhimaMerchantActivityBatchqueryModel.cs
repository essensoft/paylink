using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// ZhimaMerchantActivityBatchqueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class ZhimaMerchantActivityBatchqueryModel : AlipayObject
    {
        /// <summary>
        /// 活动号，来自活动创建接口[zhima.merchant.activity.create]
        /// </summary>
        [JsonProperty("activity_no")]
        public string ActivityNo { get; set; }

        /// <summary>
        /// 当前页数，从1开始。
        /// </summary>
        [JsonProperty("page_no")]
        public long PageNo { get; set; }

        /// <summary>
        /// 单页条目数，范围1-50之间。
        /// </summary>
        [JsonProperty("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 分页查询条件，可空，可传入多个状态；如果不传默认查询该商户下所有合法活动。状态枚举：  NOT_STARTED - 未开始  AVAILABLE - 活动中  END - 活动结束
        /// </summary>
        [JsonProperty("status_list")]
        public List<string> StatusList { get; set; }
    }
}
