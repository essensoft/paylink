using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayDataDataserviceAntdataassetsPublishtaskCreateResponse.
    /// </summary>
    public class AlipayDataDataserviceAntdataassetsPublishtaskCreateResponse : AlipayResponse
    {
        /// <summary>
        /// 发布D2任务是否成功
        /// </summary>
        [JsonPropertyName("result")]
        public bool Result { get; set; }
    }
}
