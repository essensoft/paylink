using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayExscUserFirstsignGetResponse.
    /// </summary>
    public class AlipayExscUserFirstsignGetResponse : AlipayResponse
    {
        /// <summary>
        /// 返回结果的业务类型。首次快捷绑卡业务类型 （first_sign）
        /// </summary>
        [JsonPropertyName("biz_type")]
        public string BizType { get; set; }

        /// <summary>
        /// 业务处理结果   true 无绑卡记录，本次是首次绑卡   false 曾经绑过快捷卡，本次不是首次绑卡
        /// </summary>
        [JsonPropertyName("success")]
        public bool Success { get; set; }
    }
}
