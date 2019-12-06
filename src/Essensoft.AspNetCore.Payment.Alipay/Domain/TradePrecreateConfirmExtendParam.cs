using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// TradePrecreateConfirmExtendParam Data Structure.
    /// </summary>
    public class TradePrecreateConfirmExtendParam : AlipayObject
    {
        /// <summary>
        /// 发码站点
        /// </summary>
        [JsonPropertyName("precreate_code_from")]
        public string PrecreateCodeFrom { get; set; }
    }
}
