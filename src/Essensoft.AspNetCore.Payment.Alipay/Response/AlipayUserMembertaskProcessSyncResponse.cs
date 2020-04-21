using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayUserMembertaskProcessSyncResponse.
    /// </summary>
    public class AlipayUserMembertaskProcessSyncResponse : AlipayResponse
    {
        /// <summary>
        /// 任务推进结果码
        /// </summary>
        [JsonPropertyName("result_code")]
        public string ResultCode { get; set; }

        /// <summary>
        /// 任务推进结果描述
        /// </summary>
        [JsonPropertyName("result_desc")]
        public string ResultDesc { get; set; }

        /// <summary>
        /// 异常是否可重试
        /// </summary>
        [JsonPropertyName("retriable")]
        public string Retriable { get; set; }

        /// <summary>
        /// 任务推进调用结果，不代表推进实际成功，推进是否成功由内部保证，外围无需关心
        /// </summary>
        [JsonPropertyName("success")]
        public string Success { get; set; }
    }
}
