using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayUserCertifyInfoPersonApplyModel Data Structure.
    /// </summary>
    public class AlipayUserCertifyInfoPersonApplyModel : AlipayObject
    {
        /// <summary>
        /// 用户详细地址
        /// </summary>
        [JsonPropertyName("address")]
        public string Address { get; set; }

        /// <summary>
        /// 用于识别是哪个业务来源
        /// </summary>
        [JsonPropertyName("biz_from")]
        public string BizFrom { get; set; }

        /// <summary>
        /// 证件过期时间
        /// </summary>
        [JsonPropertyName("cert_expired_date")]
        public string CertExpiredDate { get; set; }

        /// <summary>
        /// 证件号
        /// </summary>
        [JsonPropertyName("cert_no")]
        public string CertNo { get; set; }

        /// <summary>
        /// 证件类型,例如身份证类型是IDENTITY_CARD
        /// </summary>
        [JsonPropertyName("cert_type")]
        public string CertType { get; set; }

        /// <summary>
        /// 用户住址的城市名称
        /// </summary>
        [JsonPropertyName("city")]
        public string City { get; set; }

        /// <summary>
        /// 国家信息
        /// </summary>
        [JsonPropertyName("country")]
        public string Country { get; set; }

        /// <summary>
        /// 证件人像页图片SFS地址
        /// </summary>
        [JsonPropertyName("face_url")]
        public string FaceUrl { get; set; }

        /// <summary>
        /// 用户联系手机号码
        /// </summary>
        [JsonPropertyName("mobile")]
        public string Mobile { get; set; }

        /// <summary>
        /// 用户地址的省份信息
        /// </summary>
        [JsonPropertyName("province")]
        public string Province { get; set; }

        /// <summary>
        /// 男性：m,女性：f
        /// </summary>
        [JsonPropertyName("sex")]
        public string Sex { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [JsonPropertyName("user_id")]
        public string UserId { get; set; }

        /// <summary>
        /// 用户姓名
        /// </summary>
        [JsonPropertyName("user_name")]
        public string UserName { get; set; }

        /// <summary>
        /// 国微页图片SFS地址，如果非身份证类型，可不必传(例如护照，没有此页)
        /// </summary>
        [JsonPropertyName("verso_url")]
        public string VersoUrl { get; set; }
    }
}
