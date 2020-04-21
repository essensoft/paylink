using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// ZolozIdentificationCustomerCertifyzhubInitializeResponse.
    /// </summary>
    public class ZolozIdentificationCustomerCertifyzhubInitializeResponse : AlipayResponse
    {
        /// <summary>
        /// 业务单据号，用于核对和排查
        /// </summary>
        [JsonPropertyName("biz_id")]
        public string BizId { get; set; }

        /// <summary>
        /// 人脸服务端返回码
        /// </summary>
        [JsonPropertyName("zim_code")]
        public string ZimCode { get; set; }

        /// <summary>
        /// 唯一标识一次人脸服务的id
        /// </summary>
        [JsonPropertyName("zim_id")]
        public string ZimId { get; set; }

        /// <summary>
        /// 人脸服务端返回信息
        /// </summary>
        [JsonPropertyName("zim_msg")]
        public string ZimMsg { get; set; }
    }
}
