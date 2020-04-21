using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayUserUnicomMobileSyncResponse.
    /// </summary>
    public class AlipayUserUnicomMobileSyncResponse : AlipayResponse
    {
        /// <summary>
        /// 业务处理结果（成功: SUCCESS, 失败: FAIL, 重试: RETRY）
        /// </summary>
        [JsonPropertyName("mobile_sync_result")]
        public string MobileSyncResult { get; set; }

        /// <summary>
        /// 回传的业务流水号
        /// </summary>
        [JsonPropertyName("out_biz_no")]
        public string OutBizNo { get; set; }
    }
}
