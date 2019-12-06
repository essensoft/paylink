using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// MerchantMenber Data Structure.
    /// </summary>
    public class MerchantMenber : AlipayObject
    {
        /// <summary>
        /// 生日 yyyy-MM-dd
        /// </summary>
        [JsonPropertyName("birth")]
        public string Birth { get; set; }

        /// <summary>
        /// 手机号
        /// </summary>
        [JsonPropertyName("cell")]
        public string Cell { get; set; }

        /// <summary>
        /// 性别（男：MALE；女：FEMALE）
        /// </summary>
        [JsonPropertyName("gende")]
        public string Gende { get; set; }

        /// <summary>
        /// 姓名
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }
    }
}
