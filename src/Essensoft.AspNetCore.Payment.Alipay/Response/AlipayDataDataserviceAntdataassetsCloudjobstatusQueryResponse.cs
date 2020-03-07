using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayDataDataserviceAntdataassetsCloudjobstatusQueryResponse.
    /// </summary>
    public class AlipayDataDataserviceAntdataassetsCloudjobstatusQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 上云任务失败时给出的任务错误信息
        /// </summary>
        [JsonPropertyName("error_message")]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// 上云任务状态
        /// </summary>
        [JsonPropertyName("status")]
        public long Status { get; set; }
    }
}
