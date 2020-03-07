using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AttachmentDetail Data Structure.
    /// </summary>
    public class AttachmentDetail : AlipayObject
    {
        /// <summary>
        /// 创建流程时指定的附件code，可能为空。（身份证正反面的固定code：正面：ESIGN_IDCARD，背面：ESIGN_BACK_IDCARD）
        /// </summary>
        [JsonPropertyName("code")]
        public string Code { get; set; }

        /// <summary>
        /// 附件文件名
        /// </summary>
        [JsonPropertyName("file_name")]
        public string FileName { get; set; }

        /// <summary>
        /// 附件下载地址
        /// </summary>
        [JsonPropertyName("file_url")]
        public string FileUrl { get; set; }
    }
}
