using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AntMerchantExpandActivityQualificationQueryResponse.
    /// </summary>
    public class AntMerchantExpandActivityQualificationQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 用户无资格时的具体原因
        /// </summary>
        [JsonPropertyName("detail_msg")]
        public string DetailMsg { get; set; }

        /// <summary>
        /// 用户无资格时的错误码
        /// </summary>
        [JsonPropertyName("error_code")]
        public string ErrorCode { get; set; }

        /// <summary>
        /// 是否有资格
        /// </summary>
        [JsonPropertyName("has_qualification")]
        public string HasQualification { get; set; }
    }
}
