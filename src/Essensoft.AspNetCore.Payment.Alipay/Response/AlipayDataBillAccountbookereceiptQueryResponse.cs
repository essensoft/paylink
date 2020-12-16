using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayDataBillAccountbookereceiptQueryResponse.
    /// </summary>
    public class AlipayDataBillAccountbookereceiptQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 下载链接。status为SUCCESS时返回。用户可以使用此http链接下载文件内容。有效时间20s。 生成的文件是zip格式。需要解压后获取电子回单pdf内容
        /// </summary>
        [JsonPropertyName("download_url")]
        public string DownloadUrl { get; set; }

        /// <summary>
        /// 如果生成失败，则会返回失败原因
        /// </summary>
        [JsonPropertyName("error_message")]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// 处理状态   * INIT - 初始化   * PROCESS - 处理中   * SUCCESS - 成功   * FAIL - 失败
        /// </summary>
        [JsonPropertyName("status")]
        public string Status { get; set; }
    }
}
