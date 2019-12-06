using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayOpenAppYufalingsanyaowubYufalingsanyaowubQueryModel Data Structure.
    /// </summary>
    public class AlipayOpenAppYufalingsanyaowubYufalingsanyaowubQueryModel : AlipayObject
    {
        /// <summary>
        /// yufaa
        /// </summary>
        [JsonPropertyName("yufaa")]
        public string Yufaa { get; set; }
    }
}
