using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayOverseasTravelShopSyncResponse.
    /// </summary>
    public class AlipayOverseasTravelShopSyncResponse : AlipayResponse
    {
        /// <summary>
        /// 当前店铺业务状态。NORMAL：正常开业中；CLOSED ：已停业
        /// </summary>
        [JsonPropertyName("shop_biz_status")]
        public string ShopBizStatus { get; set; }

        /// <summary>
        /// 同步返回的请求处理结果。PROCESSING：处理中；SUCCESS:处理成功；FAILED:处理失败。当返回状态为PROCESSING时需要等到最终处理成功再发起同步请求进行更新操作。
        /// </summary>
        [JsonPropertyName("sync_status")]
        public string SyncStatus { get; set; }
    }
}
