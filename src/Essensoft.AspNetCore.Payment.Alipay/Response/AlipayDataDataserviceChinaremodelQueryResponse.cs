using Newtonsoft.Json;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayDataDataserviceChinaremodelQueryResponse.
    /// </summary>
    public class AlipayDataDataserviceChinaremodelQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 中再核保模型查询结果
        /// </summary>
        [JsonProperty("result")]
        public AlipayChinareModelResult Result { get; set; }
    }
}
