using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// CertFields Data Structure.
    /// </summary>
    public class CertFields : AlipayObject
    {
        /// <summary>
        /// 地址
        /// </summary>
        [JsonPropertyName("address")]
        public string Address { get; set; }

        /// <summary>
        /// 生日
        /// </summary>
        [JsonPropertyName("birth")]
        public string Birth { get; set; }

        /// <summary>
        /// 证件号码
        /// </summary>
        [JsonPropertyName("certno")]
        public string Certno { get; set; }

        /// <summary>
        /// 有效期
        /// </summary>
        [JsonPropertyName("expires")]
        public string Expires { get; set; }

        /// <summary>
        /// 有效期结束日期
        /// </summary>
        [JsonPropertyName("expiresend")]
        public string Expiresend { get; set; }

        /// <summary>
        /// 有效期开始时间
        /// </summary>
        [JsonPropertyName("expiresstart")]
        public string Expiresstart { get; set; }

        /// <summary>
        /// 签发机关
        /// </summary>
        [JsonPropertyName("issuingauthority")]
        public string Issuingauthority { get; set; }

        /// <summary>
        /// 名字
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// 编号
        /// </summary>
        [JsonPropertyName("number")]
        public string Number { get; set; }

        /// <summary>
        /// 民族
        /// </summary>
        [JsonPropertyName("race")]
        public string Race { get; set; }

        /// <summary>
        /// 换证次数
        /// </summary>
        [JsonPropertyName("renewalnum")]
        public string Renewalnum { get; set; }

        /// <summary>
        /// 性别
        /// </summary>
        [JsonPropertyName("sex")]
        public string Sex { get; set; }
    }
}
