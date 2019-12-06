using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayUserAntarchiveFaceQueryModel Data Structure.
    /// </summary>
    public class AlipayUserAntarchiveFaceQueryModel : AlipayObject
    {
        /// <summary>
        /// 出生日期(RFC3339格式)，yyyy-MM-dd，可选.若证件类型为105(港澳居民往来内地通行证)或106(台湾居民往来内地通行证)时,cert_expire_date与birthday至少填写一项
        /// </summary>
        [JsonPropertyName("birthday")]
        public string Birthday { get; set; }

        /// <summary>
        /// 证件过期日期(RFC3339格式)，yyyy-MM-dd，可选.若证件类型为105(港澳居民往来内地通行证)或106(台湾居民往来内地通行证)时,cert_expire_date与birthday至少填写一项
        /// </summary>
        [JsonPropertyName("cert_expire_date")]
        public string CertExpireDate { get; set; }

        /// <summary>
        /// 证件上的姓名
        /// </summary>
        [JsonPropertyName("cert_name")]
        public string CertName { get; set; }

        /// <summary>
        /// 证件号.若证件类型为105(港澳居民往来内地通行证),需将换证次数拼接到证件号后,如H8746985300
        /// </summary>
        [JsonPropertyName("cert_no")]
        public string CertNo { get; set; }

        /// <summary>
        /// 证件类型,取值范围为:  100 居民身份证  102 护照  105 港澳居民往来内地通行证  106 台湾居民往来内地通行证
        /// </summary>
        [JsonPropertyName("cert_type")]
        public string CertType { get; set; }

        /// <summary>
        /// 性别,可选.取值范围:  1 男  2 女
        /// </summary>
        [JsonPropertyName("gender")]
        public string Gender { get; set; }
    }
}
