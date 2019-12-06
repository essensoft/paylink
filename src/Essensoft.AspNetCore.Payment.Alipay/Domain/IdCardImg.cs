using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// IdCardImg Data Structure.
    /// </summary>
    public class IdCardImg : AlipayObject
    {
        /// <summary>
        /// 证件类型，营业执照：businessLicense，身份证：IDCARD
        /// </summary>
        [JsonPropertyName("cardtype")]
        public string Cardtype { get; set; }

        /// <summary>
        /// 图片地址，支持一个证件的多页照片同时传入，key:页码，value:图片地址。页码从1开始递增，身份证人脸面为1，国徽面为2。  图片地址若是oss地址的话，将bucket的名称组装到path里
        /// </summary>
        [JsonPropertyName("imgurls")]
        public string Imgurls { get; set; }

        /// <summary>
        /// 图片地址类型，SFS 或OSS
        /// </summary>
        [JsonPropertyName("imgurltype")]
        public string Imgurltype { get; set; }
    }
}
