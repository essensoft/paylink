using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayCommerceEducateCreditbankStudyprofileModifyModel Data Structure.
    /// </summary>
    public class AlipayCommerceEducateCreditbankStudyprofileModifyModel : AlipayObject
    {
        /// <summary>
        /// 学分银行用户ID
        /// </summary>
        [JsonPropertyName("cb_id")]
        public string CbId { get; set; }

        /// <summary>
        /// 获得证书信息
        /// </summary>
        [JsonPropertyName("certificate_experience")]
        public List<CreditBankCertificateExperience> CertificateExperience { get; set; }

        /// <summary>
        /// 职业培训成果数量
        /// </summary>
        [JsonPropertyName("certificate_num")]
        public long CertificateNum { get; set; }

        /// <summary>
        /// 渠道，默认值：shcreditbank(上海学分银行)
        /// </summary>
        [JsonPropertyName("channel")]
        public string Channel { get; set; }

        /// <summary>
        /// 成绩档案信息
        /// </summary>
        [JsonPropertyName("credit")]
        public List<CreditBankCredit> Credit { get; set; }

        /// <summary>
        /// 学历教育成果数量
        /// </summary>
        [JsonPropertyName("credit_num")]
        public long CreditNum { get; set; }

        /// <summary>
        /// 培训经历
        /// </summary>
        [JsonPropertyName("training")]
        public List<CreditBankTraining> Training { get; set; }

        /// <summary>
        /// 培训经历成果数量
        /// </summary>
        [JsonPropertyName("training_num")]
        public long TrainingNum { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [JsonPropertyName("user_id")]
        public string UserId { get; set; }
    }
}
