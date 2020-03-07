using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// ZhimaDataStateDataSyncResponse.
    /// </summary>
    public class ZhimaDataStateDataSyncResponse : AlipayResponse
    {
        /// <summary>
        /// 同步结果成功或失败,具体错误码在错误信息中
        /// </summary>
        [JsonPropertyName("biz_result")]
        public string BizResult { get; set; }
    }
}
