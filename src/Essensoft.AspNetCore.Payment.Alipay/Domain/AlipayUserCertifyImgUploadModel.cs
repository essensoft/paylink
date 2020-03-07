using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayUserCertifyImgUploadModel Data Structure.
    /// </summary>
    public class AlipayUserCertifyImgUploadModel : AlipayObject
    {
        /// <summary>
        /// 业务来源，用于支付宝认证系统识别是哪个业务方
        /// </summary>
        [JsonPropertyName("biz_from")]
        public string BizFrom { get; set; }

        /// <summary>
        /// 图片对应的base64字符串
        /// </summary>
        [JsonPropertyName("content")]
        public string Content { get; set; }

        /// <summary>
        /// 指定图片的存储类型，SFS与OSS,目前只有这两个值，个人图片要指定为SFS，企业类型图片要指定为OSS
        /// </summary>
        [JsonPropertyName("storage_type")]
        public string StorageType { get; set; }
    }
}
