using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayPassInstanceUpdateResponse.
    /// </summary>
    public class AlipayPassInstanceUpdateResponse : AlipayResponse
    {
        /// <summary>
        /// 接口调用返回结果信息
        /// </summary>
        [JsonPropertyName("result")]
        public string Result { get; set; }

        /// <summary>
        /// 操作成功标识【true：成功；false：失败】
        /// </summary>
        [JsonPropertyName("success")]
        public string Success { get; set; }
    }
}
