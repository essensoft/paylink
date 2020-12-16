using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayUserElectronicidUserQueryResponse.
    /// </summary>
    public class AlipayUserElectronicidUserQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 地址。用机构的AES加密后值。
        /// </summary>
        [JsonPropertyName("address")]
        public string Address { get; set; }

        /// <summary>
        /// 出生年月日(yyyyMMdd)。用机构的AES加密后值。
        /// </summary>
        [JsonPropertyName("birthday")]
        public string Birthday { get; set; }

        /// <summary>
        /// 18位身份证号。用机构的AES加密后值。
        /// </summary>
        [JsonPropertyName("cert_no")]
        public string CertNo { get; set; }

        /// <summary>
        /// 证件本人相片。base64。
        /// </summary>
        [JsonPropertyName("cert_picture")]
        public string CertPicture { get; set; }

        /// <summary>
        /// 性别(男，女)。用机构的AES加密后值。
        /// </summary>
        [JsonPropertyName("gender")]
        public string Gender { get; set; }

        /// <summary>
        /// 姓名。用机构的AES加密后值。
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// 民族。用机构的AES加密后值。
        /// </summary>
        [JsonPropertyName("nation")]
        public string Nation { get; set; }

        /// <summary>
        /// 当前人脸照片。base64。用机构的AES加密后值。敏感生物特征默认不输出，如特需请提供相应书面政策法规内容由BD向法务审批。
        /// </summary>
        [JsonPropertyName("picture")]
        public string Picture { get; set; }

        /// <summary>
        /// 机构AES秘钥，用商家RSA秘钥加密后的字符串，即数字信封。
        /// </summary>
        [JsonPropertyName("secret_key")]
        public string SecretKey { get; set; }

        /// <summary>
        /// 签发机关。用机构的AES加密后值。
        /// </summary>
        [JsonPropertyName("sign_org")]
        public string SignOrg { get; set; }

        /// <summary>
        /// 有效期开始(yyyyMMdd)。用机构的AES加密后值。
        /// </summary>
        [JsonPropertyName("valid_begin_date")]
        public string ValidBeginDate { get; set; }

        /// <summary>
        /// 有效期截止(yyyyMMdd)。用机构的AES加密后值。
        /// </summary>
        [JsonPropertyName("valid_end_date")]
        public string ValidEndDate { get; set; }
    }
}
