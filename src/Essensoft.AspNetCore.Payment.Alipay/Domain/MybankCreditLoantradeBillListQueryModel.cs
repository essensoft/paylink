using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// MybankCreditLoantradeBillListQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class MybankCreditLoantradeBillListQueryModel : AlipayObject
    {
        /// <summary>
        /// 账单状态，OVD逾期，CLE结清，NOR正常
        /// </summary>
        [JsonProperty("bill_status_list")]
        public string BillStatusList { get; set; }

        /// <summary>
        /// 账单结束时间
        /// </summary>
        [JsonProperty("end_date")]
        public string EndDate { get; set; }

        /// <summary>
        /// 外部请求号
        /// </summary>
        [JsonProperty("out_request_no")]
        public string OutRequestNo { get; set; }

        /// <summary>
        /// 分页偏移量
        /// </summary>
        [JsonProperty("page_num")]
        public long PageNum { get; set; }

        /// <summary>
        /// 分页大小，最大50
        /// </summary>
        [JsonProperty("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 方案合约编号
        /// </summary>
        [JsonProperty("product_code")]
        public string ProductCode { get; set; }

        /// <summary>
        /// 账单开始时间
        /// </summary>
        [JsonProperty("start_date")]
        public string StartDate { get; set; }

        /// <summary>
        /// 用户的基本信息，包括支付宝id，site,steUserId等
        /// </summary>
        [JsonProperty("user")]
        public UserVo User { get; set; }
    }
}
