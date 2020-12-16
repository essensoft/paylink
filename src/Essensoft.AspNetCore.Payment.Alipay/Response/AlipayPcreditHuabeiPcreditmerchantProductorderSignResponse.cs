using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayPcreditHuabeiPcreditmerchantProductorderSignResponse.
    /// </summary>
    public class AlipayPcreditHuabeiPcreditmerchantProductorderSignResponse : AlipayResponse
    {
        /// <summary>
        /// 业务是否成功字段
        /// </summary>
        [JsonPropertyName("biz_success")]
        public bool BizSuccess { get; set; }

        /// <summary>
        /// 订购单号
        /// </summary>
        [JsonPropertyName("data")]
        public string Data { get; set; }

        /// <summary>
        /// 业务错误码
        /// </summary>
        [JsonPropertyName("error_code")]
        public string ErrorCode { get; set; }

        /// <summary>
        /// 业务错误细腻
        /// </summary>
        [JsonPropertyName("error_message")]
        public string ErrorMessage { get; set; }
    }
}
