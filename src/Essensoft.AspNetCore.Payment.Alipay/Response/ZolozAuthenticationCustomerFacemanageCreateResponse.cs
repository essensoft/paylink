using Newtonsoft.Json;

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
        [JsonProperty("result")]
        public string Result { get; set; }

        /// <summary>
        /// 返回码
        /// </summary>
        [JsonProperty("retcode")]
        public string Retcode { get; set; }

        /// <summary>
        /// 返回详细码
        /// </summary>
        [JsonProperty("retcodesub")]
        public string Retcodesub { get; set; }

        /// <summary>
        /// 返回信息
        /// </summary>
        [JsonProperty("retmessage")]
        public string Retmessage { get; set; }

        /// <summary>
        /// 返回详细信息
        /// </summary>
        [JsonProperty("retmessagesub")]
        public string Retmessagesub { get; set; }
    }
}
