using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayOpenMiniContentSyncResponse.
    /// </summary>
    public class AlipayOpenMiniContentSyncResponse : AlipayResponse
    {
        /// <summary>
        /// 结果数据，json格式，可参考具体内容接入文档中的详细说明。详见https://opendocs.alipay.com/mini/00ntj5。
        /// </summary>
        [JsonPropertyName("result_data")]
        public string ResultData { get; set; }
    }
}
