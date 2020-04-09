using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayPayCodecHschoolDecodeUseModel Data Structure.
    /// </summary>
    public class AlipayPayCodecHschoolDecodeUseModel : AlipayObject
    {
        /// <summary>
        /// 码值
        /// </summary>
        [JsonPropertyName("code_value")]
        public string CodeValue { get; set; }

        /// <summary>
        /// 机构号
        /// </summary>
        [JsonPropertyName("institution_code")]
        public string InstitutionCode { get; set; }
    }
}
