using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayUserCertDocIDCard Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayUserCertDocIDCard : AlipayObject
    {
        /// <summary>
        /// 身份证国徽页照片BASE64编码
        /// </summary>
        [JsonProperty("encoded_img_emblem")]
        public string EncodedImgEmblem { get; set; }

        /// <summary>
        /// 头像页照片BASE64编码
        /// </summary>
        [JsonProperty("encoded_img_identity")]
        public string EncodedImgIdentity { get; set; }

        /// <summary>
        /// 有效期至
        /// </summary>
        [JsonProperty("expire_date")]
        public string ExpireDate { get; set; }

        /// <summary>
        /// 身份证姓名
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// 身份证号码
        /// </summary>
        [JsonProperty("number")]
        public string Number { get; set; }
    }
}
