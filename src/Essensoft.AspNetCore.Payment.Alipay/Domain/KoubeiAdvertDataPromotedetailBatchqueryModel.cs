using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KoubeiAdvertDataPromotedetailBatchqueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiAdvertDataPromotedetailBatchqueryModel : AlipayObject
    {
        /// <summary>
        /// 结束时间
        /// </summary>
        [JsonProperty("end_date")]
        public string EndDate { get; set; }

        /// <summary>
        /// 扩展信息
        /// </summary>
        [JsonProperty("ext_info")]
        public string ExtInfo { get; set; }

        /// <summary>
        /// 当前页码
        /// </summary>
        [JsonProperty("page_index")]
        public long PageIndex { get; set; }

        /// <summary>
        /// 每页大小(分页参数)
        /// </summary>
        [JsonProperty("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 开始时间
        /// </summary>
        [JsonProperty("start_date")]
        public string StartDate { get; set; }

        /// <summary>
        /// 商品券名称 支持模糊搜索
        /// </summary>
        [JsonProperty("voucher_name")]
        public string VoucherName { get; set; }
    }
}
