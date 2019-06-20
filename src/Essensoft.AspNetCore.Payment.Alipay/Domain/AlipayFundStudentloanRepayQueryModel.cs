using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayFundStudentloanRepayQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayFundStudentloanRepayQueryModel : AlipayObject
    {
        /// <summary>
        /// 还款学生的身份证号码
        /// </summary>
        [JsonProperty("cert_no")]
        public string CertNo { get; set; }

        /// <summary>
        /// 还款学生的支付宝账号
        /// </summary>
        [JsonProperty("logon_id")]
        public string LogonId { get; set; }
    }
}
