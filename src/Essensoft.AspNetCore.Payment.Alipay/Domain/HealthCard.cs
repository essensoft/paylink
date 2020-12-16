using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// HealthCard Data Structure.
    /// </summary>
    public class HealthCard : AlipayObject
    {
        /// <summary>
        /// 用户出生日期
        /// </summary>
        [JsonPropertyName("birthday")]
        public string Birthday { get; set; }

        /// <summary>
        /// 用户健康卡对应身份证号
        /// </summary>
        [JsonPropertyName("cert_no")]
        public string CertNo { get; set; }

        /// <summary>
        /// 由卫健委机构统一生成的健康卡卡号
        /// </summary>
        [JsonPropertyName("health_card_no")]
        public string HealthCardNo { get; set; }

        /// <summary>
        /// 健康卡所属用户的真实姓名
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// 用户性别，其中1代表男性，2代表女性
        /// </summary>
        [JsonPropertyName("sex")]
        public string Sex { get; set; }
    }
}
