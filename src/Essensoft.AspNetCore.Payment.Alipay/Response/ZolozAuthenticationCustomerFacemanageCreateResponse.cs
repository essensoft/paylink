using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// ZolozAuthenticationCustomerFacemanageCreateResponse.
    /// </summary>
    public class ZolozAuthenticationCustomerFacemanageCreateResponse : AlipayResponse
    {
        /// <summary>
        /// 业务结果
        /// </summary>
        [JsonPropertyName("result")]
        public string Result { get; set; }

        /// <summary>
        /// 返回码
        /// </summary>
        [JsonPropertyName("retcode")]
        public string Retcode { get; set; }

        /// <summary>
        /// 返回详细码
        /// </summary>
        [JsonPropertyName("retcodesub")]
        public string Retcodesub { get; set; }

        /// <summary>
        /// 返回信息
        /// </summary>
        [JsonPropertyName("retmessage")]
        public string Retmessage { get; set; }

        /// <summary>
        /// 返回详细信息
        /// </summary>
        [JsonPropertyName("retmessagesub")]
        public string Retmessagesub { get; set; }
    }
}
