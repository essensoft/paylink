using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// Detail Data Structure.
    /// </summary>
    public class Detail : AlipayObject
    {
        /// <summary>
        /// 英文描述（collectAttachement值为true时必填） 以下是系统固定code,对上传的图片做相应的校验。 身份证校验情况： 身份证正面照片：ESIGN_IDCARD 身份证背面照片：ESIGN_BACK_IDCARD
        /// </summary>
        [JsonPropertyName("code")]
        public string Code { get; set; }

        /// <summary>
        /// 请上传手机正面照
        /// </summary>
        [JsonPropertyName("description")]
        public string Description { get; set; }

        /// <summary>
        /// 顺序（collectAttachement值为true时必填）
        /// </summary>
        [JsonPropertyName("order")]
        public long Order { get; set; }
    }
}
