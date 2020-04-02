using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayOpenPageOldcontextTransferModel Data Structure.
    /// </summary>
    public class AlipayOpenPageOldcontextTransferModel : AlipayObject
    {
        /// <summary>
        /// 参数1
        /// </summary>
        [JsonPropertyName("param_one")]
        public string ParamOne { get; set; }

        /// <summary>
        /// 参数3
        /// </summary>
        [JsonPropertyName("param_three")]
        public string ParamThree { get; set; }

        /// <summary>
        /// 参数2
        /// </summary>
        [JsonPropertyName("param_two")]
        public string ParamTwo { get; set; }
    }
}
