using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayFundStudentloanRepayQueryModel Data Structure.
    /// </summary>
    public class AlipayFundStudentloanRepayQueryModel : AlipayObject
    {
        /// <summary>
        /// 还款学生的身份证号码
        /// </summary>
        [JsonPropertyName("cert_no")]
        public string CertNo { get; set; }

        /// <summary>
        /// 还款学生的支付宝账号
        /// </summary>
        [JsonPropertyName("logon_id")]
        public string LogonId { get; set; }
    }
}
