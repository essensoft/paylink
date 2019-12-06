using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// ApprovedInfo Data Structure.
    /// </summary>
    public class ApprovedInfo : AlipayObject
    {
        /// <summary>
        /// 用户申请订单号回传。  Unique Application No.
        /// </summary>
        [JsonPropertyName("application_no")]
        public string ApplicationNo { get; set; }

        /// <summary>
        /// URL to download approval letter  Approval letter 文件下载地址
        /// </summary>
        [JsonPropertyName("approval_letter_url")]
        public string ApprovalLetterUrl { get; set; }

        /// <summary>
        /// 泰国移民局发放的批准或拒绝码。  IMM’s code of approve or reject. Ex. “PAC2019020987654” , “NAC2019020987654”
        /// </summary>
        [JsonPropertyName("imm_code")]
        public string ImmCode { get; set; }

        /// <summary>
        /// 移民局办公室名称。  Immigration officer full name.
        /// </summary>
        [JsonPropertyName("imm_fullname")]
        public string ImmFullname { get; set; }

        /// <summary>
        /// 移民局办公室地址。  Immigration officer position.
        /// </summary>
        [JsonPropertyName("imm_position")]
        public string ImmPosition { get; set; }

        /// <summary>
        /// 记录。  Note.
        /// </summary>
        [JsonPropertyName("note")]
        public string Note { get; set; }

        /// <summary>
        /// 支付费用详情
        /// </summary>
        [JsonPropertyName("payment_confirm_url")]
        public string PaymentConfirmUrl { get; set; }

        /// <summary>
        /// URL to download receipt.  办理收据文件下载地址。
        /// </summary>
        [JsonPropertyName("receipt_url")]
        public string ReceiptUrl { get; set; }

        /// <summary>
        /// 备注。  Remark.
        /// </summary>
        [JsonPropertyName("remark")]
        public string Remark { get; set; }

        /// <summary>
        /// 申请状态：通过/拒绝。  Status of application：Approved/Rejected.
        /// </summary>
        [JsonPropertyName("status")]
        public string Status { get; set; }

        /// <summary>
        /// 批准状态变更时间。  DateTime of approved or rejected.
        /// </summary>
        [JsonPropertyName("status_date_time")]
        public string StatusDateTime { get; set; }

        /// <summary>
        /// URL to download TM.6  TM6 文件下载地址
        /// </summary>
        [JsonPropertyName("tm_6_url")]
        public string Tm6Url { get; set; }

        /// <summary>
        /// URL to download TM.88  TM88 文件下载地址。
        /// </summary>
        [JsonPropertyName("tm_88_url")]
        public string Tm88Url { get; set; }
    }
}
