using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayPcreditHuabeiPcreditmerchantProductorderTransferResponse.
    /// </summary>
    public class AlipayPcreditHuabeiPcreditmerchantProductorderTransferResponse : AlipayResponse
    {
        /// <summary>
        /// 业务成功标志
        /// </summary>
        [JsonPropertyName("biz_success")]
        public bool BizSuccess { get; set; }

        /// <summary>
        /// 订购ID
        /// </summary>
        [JsonPropertyName("data")]
        public string Data { get; set; }

        /// <summary>
        /// 业务错误码
        /// </summary>
        [JsonPropertyName("error_code")]
        public string ErrorCode { get; set; }

        /// <summary>
        /// 错误信息返回
        /// </summary>
        [JsonPropertyName("error_message")]
        public string ErrorMessage { get; set; }
    }
}
