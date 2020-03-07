using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayPayCodecAcodeCertExpireModel Data Structure.
    /// </summary>
    public class AlipayPayCodecAcodeCertExpireModel : AlipayObject
    {
        /// <summary>
        /// 用户业务身份标识
        /// </summary>
        [JsonPropertyName("biz_id")]
        public string BizId { get; set; }

        /// <summary>
        /// 机构类型
        /// </summary>
        [JsonPropertyName("institution_type")]
        public string InstitutionType { get; set; }

        /// <summary>
        /// 变更时间点，会失效该时间点之前的证书（Long型）
        /// </summary>
        [JsonPropertyName("time")]
        public long Time { get; set; }
    }
}
