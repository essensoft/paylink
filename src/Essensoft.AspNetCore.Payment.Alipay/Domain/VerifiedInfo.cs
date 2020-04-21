using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// VerifiedInfo Data Structure.
    /// </summary>
    public class VerifiedInfo : AlipayObject
    {
        /// <summary>
        /// 用户申请订单号回传。  Unique Application No.
        /// </summary>
        [JsonPropertyName("application_no")]
        public string ApplicationNo { get; set; }

        /// <summary>
        /// 扩展信息，用于保存其它补充信息。
        /// </summary>
        [JsonPropertyName("ext_info")]
        public string ExtInfo { get; set; }

        /// <summary>
        /// 审核记录。  Note.
        /// </summary>
        [JsonPropertyName("note")]
        public string Note { get; set; }

        /// <summary>
        /// 审核备注。  Remark.
        /// </summary>
        [JsonPropertyName("remark")]
        public string Remark { get; set; }

        /// <summary>
        /// 审核状态：通过/拒绝。  Status of application：Verified/Rejected.
        /// </summary>
        [JsonPropertyName("status")]
        public string Status { get; set; }

        /// <summary>
        /// 审核负责单位。  Name of user who do verify.
        /// </summary>
        [JsonPropertyName("verified_by")]
        public string VerifiedBy { get; set; }

        /// <summary>
        /// 审核时间。  DateTime of verified or rejected.
        /// </summary>
        [JsonPropertyName("verify_date_time")]
        public string VerifyDateTime { get; set; }
    }
}
