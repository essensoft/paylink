using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// ZolozIdentificationCustomerEnrollcertifyQueryResponse.
    /// </summary>
    public class ZolozIdentificationCustomerEnrollcertifyQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 是否为攻击
        /// </summary>
        [JsonPropertyName("attack")]
        public bool Attack { get; set; }

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
