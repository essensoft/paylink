using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// SsdataDataserviceDtevalIdentitycheckQueryModel Data Structure.
    /// </summary>
    public class SsdataDataserviceDtevalIdentitycheckQueryModel : AlipayObject
    {
        /// <summary>
        /// 工单流水号
        /// </summary>
        [JsonPropertyName("biz_no")]
        public string BizNo { get; set; }

        /// <summary>
        /// 采集到的身份证号
        /// </summary>
        [JsonPropertyName("col_cert_no")]
        public string ColCertNo { get; set; }

        /// <summary>
        /// 采集到的手机号码
        /// </summary>
        [JsonPropertyName("col_mobile")]
        public string ColMobile { get; set; }

        /// <summary>
        /// 采集到的姓名
        /// </summary>
        [JsonPropertyName("col_user_name")]
        public string ColUserName { get; set; }

        /// <summary>
        /// 额外参数
        /// </summary>
        [JsonPropertyName("ext_map")]
        public string ExtMap { get; set; }

        /// <summary>
        /// 实际身份证号
        /// </summary>
        [JsonPropertyName("real_cert_no")]
        public string RealCertNo { get; set; }

        /// <summary>
        /// 实际手机号号码
        /// </summary>
        [JsonPropertyName("real_mobile")]
        public string RealMobile { get; set; }

        /// <summary>
        /// 实际姓名
        /// </summary>
        [JsonPropertyName("real_user_name")]
        public string RealUserName { get; set; }
    }
}
