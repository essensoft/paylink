using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayCommerceEducateFacefeatureFileApplyResponse.
    /// </summary>
    public class AlipayCommerceEducateFacefeatureFileApplyResponse : AlipayResponse
    {
        /// <summary>
        /// 文件下载url
        /// </summary>
        [JsonPropertyName("download_url")]
        public string DownloadUrl { get; set; }

        /// <summary>
        /// 文件日期
        /// </summary>
        [JsonPropertyName("file_date")]
        public string FileDate { get; set; }

        /// <summary>
        /// 机构ID+ISV名称+BIZ_CODE+日期+特征版本
        /// </summary>
        [JsonPropertyName("file_name")]
        public string FileName { get; set; }

        /// <summary>
        /// 文件生成状态
        /// </summary>
        [JsonPropertyName("file_status")]
        public string FileStatus { get; set; }
    }
}
