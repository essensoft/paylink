using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// MybankCreditLoantradeBillListQueryModel Data Structure.
    /// </summary>
    public class MybankCreditLoantradeBillListQueryModel : AlipayObject
    {
        /// <summary>
        /// 账单编号列表，最多支持20条记录查询
        /// </summary>
        [JsonPropertyName("bill_no_list")]
        public string BillNoList { get; set; }

        /// <summary>
        /// 账单状态，OVD逾期，CLE结清，NOR正常
        /// </summary>
        [JsonPropertyName("bill_status_list")]
        public string BillStatusList { get; set; }

        /// <summary>
        /// 账单结束时间
        /// </summary>
        [JsonPropertyName("end_date")]
        public string EndDate { get; set; }

        /// <summary>
        /// 外部请求号
        /// </summary>
        [JsonPropertyName("out_request_no")]
        public string OutRequestNo { get; set; }

        /// <summary>
        /// 分页偏移量
        /// </summary>
        [JsonPropertyName("page_num")]
        public long PageNum { get; set; }

        /// <summary>
        /// 分页大小，最大50
        /// </summary>
        [JsonPropertyName("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 方案合约编号
        /// </summary>
        [JsonPropertyName("product_code")]
        public string ProductCode { get; set; }

        /// <summary>
        /// 账单开始时间
        /// </summary>
        [JsonPropertyName("start_date")]
        public string StartDate { get; set; }

        /// <summary>
        /// 用户的基本信息，包括支付宝id，site,steUserId等
        /// </summary>
        [JsonPropertyName("user")]
        public UserVo User { get; set; }
    }
}
