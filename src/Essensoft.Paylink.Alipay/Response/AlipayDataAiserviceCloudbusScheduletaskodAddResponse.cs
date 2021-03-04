using System.Text.Json.Serialization;
using Essensoft.Paylink.Alipay.Domain;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// AlipayDataAiserviceCloudbusScheduletaskodAddResponse.
    /// </summary>
    public class AlipayDataAiserviceCloudbusScheduletaskodAddResponse : AlipayResponse
    {
        /// <summary>
        /// 任务结果
        /// </summary>
        [JsonPropertyName("result")]
        public CloudbusCommonResult Result { get; set; }
    }
}
