using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayUserUnicomOrderInfoSyncResponse.
    /// </summary>
    public class AlipayUserUnicomOrderInfoSyncResponse : AlipayResponse
    {
        /// <summary>
        /// 联通订单号
        /// </summary>
        [JsonPropertyName("order_no")]
        public string OrderNo { get; set; }

        /// <summary>
        /// 业务处理结果 （成功: SUCCESS, 失败: FAIL, 重试: RETRY）
        /// </summary>
        [JsonPropertyName("order_sync_result")]
        public string OrderSyncResult { get; set; }
    }
}
