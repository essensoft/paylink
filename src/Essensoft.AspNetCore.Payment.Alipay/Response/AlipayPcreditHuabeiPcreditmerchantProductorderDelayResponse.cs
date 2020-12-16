using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayPcreditHuabeiPcreditmerchantProductorderDelayResponse.
    /// </summary>
    public class AlipayPcreditHuabeiPcreditmerchantProductorderDelayResponse : AlipayResponse
    {
        /// <summary>
        /// 业务成功标志
        /// </summary>
        [JsonPropertyName("biz_success")]
        public bool BizSuccess { get; set; }

        /// <summary>
        /// 订单编号
        /// </summary>
        [JsonPropertyName("data")]
        public string Data { get; set; }

        /// <summary>
        /// 业务错误码
        /// </summary>
        [JsonPropertyName("error_code")]
        public string ErrorCode { get; set; }

        /// <summary>
        /// 业务错误信息
        /// </summary>
        [JsonPropertyName("error_message")]
        public string ErrorMessage { get; set; }
    }
}
