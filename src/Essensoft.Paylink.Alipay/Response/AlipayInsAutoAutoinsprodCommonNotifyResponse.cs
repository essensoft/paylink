using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// AlipayInsAutoAutoinsprodCommonNotifyResponse.
    /// </summary>
    public class AlipayInsAutoAutoinsprodCommonNotifyResponse : AlipayResponse
    {
        /// <summary>
        /// 具体内容按照业务类型对应的key值传输
        /// </summary>
        [JsonPropertyName("biz_data")]
        public string BizData { get; set; }
    }
}
