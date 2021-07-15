using System.Text.Json.Serialization;
using Essensoft.Paylink.Alipay.Domain;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// AlipayCommerceMedicalCardAuthQueryResponse.
    /// </summary>
    public class AlipayCommerceMedicalCardAuthQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 医保电子凭证或电子社保卡信息
        /// </summary>
        [JsonPropertyName("data")]
        public MedicalCardInfoList Data { get; set; }

        /// <summary>
        /// 接口错误描述
        /// </summary>
        [JsonPropertyName("error_message")]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// 业务错误码
        /// </summary>
        [JsonPropertyName("result_code")]
        public string ResultCode { get; set; }
    }
}
