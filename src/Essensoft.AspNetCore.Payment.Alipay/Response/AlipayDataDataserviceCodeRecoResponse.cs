using Newtonsoft.Json;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayDataDataserviceCodeRecoResponse.
    /// </summary>
    public class AlipayDataDataserviceCodeRecoResponse : AlipayResponse
    {
        /// <summary>
        /// 识别结果
        /// </summary>
        [JsonProperty("result")]
        public AlipayCodeRecoResult Result { get; set; }
    }
}
