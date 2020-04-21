using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// ZolozAuthenticationCustomerFtokenQueryModel Data Structure.
    /// </summary>
    public class ZolozAuthenticationCustomerFtokenQueryModel : AlipayObject
    {
        /// <summary>
        /// 1、1：1人脸验证能力  2、1：n人脸搜索能力（支付宝uid入库）  3、1：n人脸搜索能力（支付宝手机号入库）  4、手机号和人脸识别综合能力
        /// </summary>
        [JsonPropertyName("biz_type")]
        public string BizType { get; set; }

        /// <summary>
        /// 人脸产品拓展参数
        /// </summary>
        [JsonPropertyName("ext_info")]
        public FaceExtInfo ExtInfo { get; set; }

        /// <summary>
        /// 人脸token
        /// </summary>
        [JsonPropertyName("ftoken")]
        public string Ftoken { get; set; }
    }
}
