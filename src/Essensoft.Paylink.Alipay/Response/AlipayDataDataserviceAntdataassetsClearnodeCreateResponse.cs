using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// AlipayDataDataserviceAntdataassetsClearnodeCreateResponse.
    /// </summary>
    public class AlipayDataDataserviceAntdataassetsClearnodeCreateResponse : AlipayResponse
    {
        /// <summary>
        /// 清除任务操作是否成功
        /// </summary>
        [JsonPropertyName("result")]
        public bool Result { get; set; }
    }
}
