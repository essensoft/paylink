using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayOpenLotterymallExchangerecordstatusSyncResponse.
    /// </summary>
    public class AlipayOpenLotterymallExchangerecordstatusSyncResponse : AlipayResponse
    {
        /// <summary>
        /// 如果success为false，errorCode表示具体的失败错误码
        /// </summary>
        [JsonPropertyName("errorcode")]
        public string Errorcode { get; set; }

        /// <summary>
        /// 如果success为false时，errormsg 表示具体的失败原因
        /// </summary>
        [JsonPropertyName("errormsg")]
        public string Errormsg { get; set; }

        /// <summary>
        /// 本次业务处理是否成功，true表示成功，false表示失败
        /// </summary>
        [JsonPropertyName("success")]
        public bool Success { get; set; }
    }
}
