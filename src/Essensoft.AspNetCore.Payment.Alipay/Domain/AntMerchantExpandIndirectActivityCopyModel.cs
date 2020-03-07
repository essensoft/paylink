using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AntMerchantExpandIndirectActivityCopyModel Data Structure.
    /// </summary>
    public class AntMerchantExpandIndirectActivityCopyModel : AlipayObject
    {
        /// <summary>
        /// 转移内容，数组类型。目前可选值(不包含引号)："blue_sea"
        /// </summary>
        [JsonPropertyName("copy_contents")]
        public List<string> CopyContents { get; set; }

        /// <summary>
        /// 活动权益复制源smid
        /// </summary>
        [JsonPropertyName("source_smid")]
        public string SourceSmid { get; set; }

        /// <summary>
        /// 活动权益复制目标smid
        /// </summary>
        [JsonPropertyName("target_smid")]
        public string TargetSmid { get; set; }
    }
}
