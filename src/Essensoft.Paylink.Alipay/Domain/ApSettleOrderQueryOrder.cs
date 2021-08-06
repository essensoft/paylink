using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// ApSettleOrderQueryOrder Data Structure.
    /// </summary>
    public class ApSettleOrderQueryOrder : AlipayObject
    {
        /// <summary>
        /// 付款申请单ID
        /// </summary>
        [JsonPropertyName("apply_id")]
        public string ApplyId { get; set; }

        /// <summary>
        /// 1
        /// </summary>
        [JsonPropertyName("bill_no")]
        public string BillNo { get; set; }

        /// <summary>
        /// 结束日期
        /// </summary>
        [JsonPropertyName("end_date")]
        public string EndDate { get; set; }

        /// <summary>
        /// 机构
        /// </summary>
        [JsonPropertyName("inst_id")]
        public string InstId { get; set; }

        /// <summary>
        /// 结算Pid
        /// </summary>
        [JsonPropertyName("ip_role_id")]
        public string IpRoleId { get; set; }

        /// <summary>
        /// 起始日期
        /// </summary>
        [JsonPropertyName("start_date")]
        public string StartDate { get; set; }

        /// <summary>
        /// 状态
        /// </summary>
        [JsonPropertyName("status")]
        public string Status { get; set; }
    }
}
