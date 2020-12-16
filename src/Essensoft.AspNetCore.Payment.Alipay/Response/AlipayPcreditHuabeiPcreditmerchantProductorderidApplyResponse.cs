using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayPcreditHuabeiPcreditmerchantProductorderidApplyResponse.
    /// </summary>
    public class AlipayPcreditHuabeiPcreditmerchantProductorderidApplyResponse : AlipayResponse
    {
        /// <summary>
        /// 业务成功标志
        /// </summary>
        [JsonPropertyName("biz_success")]
        public bool BizSuccess { get; set; }

        /// <summary>
        /// 订购单号
        /// </summary>
        [JsonPropertyName("data")]
        public string Data { get; set; }

        /// <summary>
        /// 错误码
        /// </summary>
        [JsonPropertyName("error_code")]
        public string ErrorCode { get; set; }
    }
}
