using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// SpecifyAttachmentInfo Data Structure.
    /// </summary>
    public class SpecifyAttachmentInfo : AlipayObject
    {
        /// <summary>
        /// 是否允许上传更多附件，默认值为false。开启后，除了“collect_common_codes”中指定的附件，签署人可自由上传至多10张图片。
        /// </summary>
        [JsonPropertyName("allow_more_uploads")]
        public bool AllowMoreUploads { get; set; }

        /// <summary>
        /// 允许上传更多附件时，可上传的最大附件数，一次流程中累计的上传附件数至多30（含“附件列表”数量）
        /// </summary>
        [JsonPropertyName("allow_more_uploads_max_count")]
        public long AllowMoreUploadsMaxCount { get; set; }

        /// <summary>
        /// 需要签署人上传的证件照片，可进行ORC识别，目前仅支持IDCARD
        /// </summary>
        [JsonPropertyName("collect_cert_types")]
        public List<string> CollectCertTypes { get; set; }

        /// <summary>
        /// 需要签署人上传的其他附件列表，即attachment_explain.details中定义的code列表
        /// </summary>
        [JsonPropertyName("collect_common_codes")]
        public List<string> CollectCommonCodes { get; set; }

        /// <summary>
        /// 个人唯一标识，对应签署区中指定的签署人
        /// </summary>
        [JsonPropertyName("third_party_user_id")]
        public string ThirdPartyUserId { get; set; }
    }
}
