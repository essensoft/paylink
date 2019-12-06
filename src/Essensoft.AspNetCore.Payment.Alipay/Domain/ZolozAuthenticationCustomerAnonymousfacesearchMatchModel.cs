using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// ZolozAuthenticationCustomerAnonymousfacesearchMatchModel Data Structure.
    /// </summary>
    public class ZolozAuthenticationCustomerAnonymousfacesearchMatchModel : AlipayObject
    {
        /// <summary>
        /// 防攻击能力参数
        /// </summary>
        [JsonPropertyName("antiattack")]
        public string Antiattack { get; set; }

        /// <summary>
        /// 地域编码
        /// </summary>
        [JsonPropertyName("areacode")]
        public string Areacode { get; set; }

        /// <summary>
        /// 活体照片的二进制内容，然后做base64编码
        /// </summary>
        [JsonPropertyName("authimg")]
        public string Authimg { get; set; }

        /// <summary>
        /// 代表业务方接入编号
        /// </summary>
        [JsonPropertyName("biz_type")]
        public string BizType { get; set; }

        /// <summary>
        /// 业务量规模
        /// </summary>
        [JsonPropertyName("bizscale")]
        public string Bizscale { get; set; }

        /// <summary>
        /// 商户品牌
        /// </summary>
        [JsonPropertyName("brandcode")]
        public string Brandcode { get; set; }

        /// <summary>
        /// 商户机具唯一编码，关键参数
        /// </summary>
        [JsonPropertyName("devicenum")]
        public string Devicenum { get; set; }

        /// <summary>
        /// 拓展参数
        /// </summary>
        [JsonPropertyName("extinfo")]
        public string Extinfo { get; set; }

        /// <summary>
        /// 群组
        /// </summary>
        [JsonPropertyName("group")]
        public string Group { get; set; }

        /// <summary>
        /// 门店编码
        /// </summary>
        [JsonPropertyName("storecode")]
        public string Storecode { get; set; }

        /// <summary>
        /// 有效期天数，如7天、30天、365天
        /// </summary>
        [JsonPropertyName("validtimes")]
        public string Validtimes { get; set; }
    }
}
