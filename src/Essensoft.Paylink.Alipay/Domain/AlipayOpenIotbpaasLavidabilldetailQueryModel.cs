using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// AlipayOpenIotbpaasLavidabilldetailQueryModel Data Structure.
    /// </summary>
    public class AlipayOpenIotbpaasLavidabilldetailQueryModel : AlipayObject
    {
        /// <summary>
        /// 收款时间或者退款时间，yyyy-MM-dd HH:mm:ss格式
        /// </summary>
        [JsonPropertyName("gmt_recv_pay")]
        public string GmtRecvPay { get; set; }

        /// <summary>
        /// 收支单据号
        /// </summary>
        [JsonPropertyName("rp_record_id")]
        public string RpRecordId { get; set; }

        /// <summary>
        /// 收支类型，1：交易收款；2：交易退款
        /// </summary>
        [JsonPropertyName("rp_record_type")]
        public long RpRecordType { get; set; }
    }
}
