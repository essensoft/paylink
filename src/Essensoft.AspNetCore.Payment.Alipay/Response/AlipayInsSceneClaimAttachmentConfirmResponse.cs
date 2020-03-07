using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayInsSceneClaimAttachmentConfirmResponse.
    /// </summary>
    public class AlipayInsSceneClaimAttachmentConfirmResponse : AlipayResponse
    {
        /// <summary>
        /// 差异的文件清单列表
        /// </summary>
        [JsonPropertyName("lost_files")]
        public List<string> LostFiles { get; set; }

        /// <summary>
        /// 文件上传的状态,清单和实际文件一致的返回SUCCEED，不一致的返回FAIL，同时给出lost_files清单
        /// </summary>
        [JsonPropertyName("status")]
        public string Status { get; set; }
    }
}
