using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayUserCertDocIDCard Data Structure.
    /// </summary>
    public class AlipayUserCertDocIDCard : AlipayObject
    {
        /// <summary>
        /// 身份证国徽页照片BASE64编码
        /// </summary>
        [JsonPropertyName("encoded_img_emblem")]
        public string EncodedImgEmblem { get; set; }

        /// <summary>
        /// 头像页照片BASE64编码
        /// </summary>
        [JsonPropertyName("encoded_img_identity")]
        public string EncodedImgIdentity { get; set; }

        /// <summary>
        /// 有效期至
        /// </summary>
        [JsonPropertyName("expire_date")]
        public string ExpireDate { get; set; }

        /// <summary>
        /// 身份证姓名
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// 身份证号码
        /// </summary>
        [JsonPropertyName("number")]
        public string Number { get; set; }
    }
}
