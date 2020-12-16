using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayOpenAppSystemNewcontextupiduoidTransferModel Data Structure.
    /// </summary>
    public class AlipayOpenAppSystemNewcontextupiduoidTransferModel : AlipayObject
    {
        /// <summary>
        /// 101
        /// </summary>
        [JsonPropertyName("param_one")]
        public string ParamOne { get; set; }
    }
}
