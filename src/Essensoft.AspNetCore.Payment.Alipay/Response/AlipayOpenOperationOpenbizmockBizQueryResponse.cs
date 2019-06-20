using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayOpenOperationOpenbizmockBizQueryResponse.
    /// </summary>
    public class AlipayOpenOperationOpenbizmockBizQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 处理结果
        /// </summary>
        [JsonProperty("result")]
        public string Result { get; set; }
    }
}
