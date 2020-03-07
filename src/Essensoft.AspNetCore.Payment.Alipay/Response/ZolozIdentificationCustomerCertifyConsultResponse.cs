using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// ZolozIdentificationCustomerCertifyConsultResponse.
    /// </summary>
    public class ZolozIdentificationCustomerCertifyConsultResponse : AlipayResponse
    {
        /// <summary>
        /// 业务单据号，用于核对和排查
        /// </summary>
        [JsonPropertyName("biz_id")]
        public string BizId { get; set; }

        /// <summary>
        /// 图片字节数组进行Base64编码后的字符串
        /// </summary>
        [JsonPropertyName("img_str")]
        public string ImgStr { get; set; }
    }
}
