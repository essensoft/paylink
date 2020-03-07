using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayUserAntpaasAddtesttagModifyResponse.
    /// </summary>
    public class AlipayUserAntpaasAddtesttagModifyResponse : AlipayResponse
    {
        /// <summary>
        /// 返回是否有标记或者是否达标成功，success，msg
        /// </summary>
        [JsonPropertyName("result")]
        public string Result { get; set; }
    }
}
