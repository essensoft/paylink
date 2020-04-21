using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayOpenMiniPayeeUnbindResponse.
    /// </summary>
    public class AlipayOpenMiniPayeeUnbindResponse : AlipayResponse
    {
        /// <summary>
        /// 解绑结果，true解绑成功，false解绑失败
        /// </summary>
        [JsonPropertyName("result")]
        public bool Result { get; set; }
    }
}
