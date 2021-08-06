using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// LiveContentInfo Data Structure.
    /// </summary>
    public class LiveContentInfo : AlipayObject
    {
        /// <summary>
        /// 素材的业务类型，可以区分针对不同素材匹配不同的业务规则。
        /// </summary>
        [JsonPropertyName("biz_content_type")]
        public string BizContentType { get; set; }

        /// <summary>
        /// 物料类型 (TEXT:文本/PICTURE:图片/VOICE:语音/VIDEO:视频)
        /// </summary>
        [JsonPropertyName("content_file_type")]
        public string ContentFileType { get; set; }

        /// <summary>
        /// 物料的唯一代码
        /// </summary>
        [JsonPropertyName("content_id")]
        public string ContentId { get; set; }

        /// <summary>
        /// 物料风险信息列表
        /// </summary>
        [JsonPropertyName("content_risk_info_list")]
        public List<LiveContentRiskInfo> ContentRiskInfoList { get; set; }

        /// <summary>
        /// 视频转换的文本的url地址
        /// </summary>
        [JsonPropertyName("content_url")]
        public string ContentUrl { get; set; }

        /// <summary>
        /// 打点标签名称
        /// </summary>
        [JsonPropertyName("mark_lable_name")]
        public string MarkLableName { get; set; }
    }
}
