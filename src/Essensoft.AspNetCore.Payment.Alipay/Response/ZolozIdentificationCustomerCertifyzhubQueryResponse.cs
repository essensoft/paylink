using System.Text.Json.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// ZolozIdentificationCustomerCertifyzhubQueryResponse.
    /// </summary>
    public class ZolozIdentificationCustomerCertifyzhubQueryResponse : AlipayResponse
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
        /// 人脸属性信息，提供对人脸base64图片的额外描述，包括不限于人脸矩形框。目前仅为矩形框，无需脱敏。
        /// </summary>
        [JsonPropertyName("face_attr_info")]
        public FaceAttrInfo FaceAttrInfo { get; set; }

        /// <summary>
        /// 图片字节数组进行Base64编码后的字符串
        /// </summary>
        [JsonPropertyName("img_str")]
        public string ImgStr { get; set; }

        /// <summary>
        /// 人脸服务端返回码
        /// </summary>
        [JsonPropertyName("zim_code")]
        public string ZimCode { get; set; }

        /// <summary>
        /// 人脸服务端返回信息
        /// </summary>
        [JsonPropertyName("zim_msg")]
        public string ZimMsg { get; set; }
    }
}
