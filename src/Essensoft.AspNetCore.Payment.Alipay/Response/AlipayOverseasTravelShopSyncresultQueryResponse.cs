using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayOverseasTravelShopSyncresultQueryResponse.
    /// </summary>
    public class AlipayOverseasTravelShopSyncresultQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 当前店铺业务状态。NORMAL：正常开业中；CLOSED ：已停业
        /// </summary>
        [JsonPropertyName("shop_biz_status")]
        public string ShopBizStatus { get; set; }

        /// <summary>
        /// 店铺信息处理失败的错误码，如转链错误，风控审核错误等
        /// </summary>
        [JsonPropertyName("sync_failed_code")]
        public string SyncFailedCode { get; set; }

        /// <summary>
        /// 店铺信息处理失败时的错误描述
        /// </summary>
        [JsonPropertyName("sync_failed_msg")]
        public string SyncFailedMsg { get; set; }

        /// <summary>
        /// 同步返回的请求处理结果。PROCESSING：处理中；SUCCESS:处理成功；FAILED:处理失败。 轮询查询时基于此结果判断店铺是否同步成功。
        /// </summary>
        [JsonPropertyName("sync_status")]
        public string SyncStatus { get; set; }
    }
}
