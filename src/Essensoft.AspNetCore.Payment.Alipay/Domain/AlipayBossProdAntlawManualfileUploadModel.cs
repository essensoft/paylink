using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayBossProdAntlawManualfileUploadModel Data Structure.
    /// </summary>
    public class AlipayBossProdAntlawManualfileUploadModel : AlipayObject
    {
        /// <summary>
        /// 业务编号
        /// </summary>
        [JsonPropertyName("biz_code")]
        public string BizCode { get; set; }

        /// <summary>
        /// 文件列表
        /// </summary>
        [JsonPropertyName("file_list")]
        public List<ContractFileVO> FileList { get; set; }

        /// <summary>
        /// 鉴权token
        /// </summary>
        [JsonPropertyName("request_token")]
        public string RequestToken { get; set; }

        /// <summary>
        /// 来源系统
        /// </summary>
        [JsonPropertyName("source_sys")]
        public string SourceSys { get; set; }

        /// <summary>
        /// 请求时间戳
        /// </summary>
        [JsonPropertyName("time_stamp")]
        public string TimeStamp { get; set; }
    }
}
