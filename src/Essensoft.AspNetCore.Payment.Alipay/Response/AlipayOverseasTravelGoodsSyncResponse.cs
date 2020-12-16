using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayOverseasTravelGoodsSyncResponse.
    /// </summary>
    public class AlipayOverseasTravelGoodsSyncResponse : AlipayResponse
    {
        /// <summary>
        /// 商品状态，NORMAL表示如正在售卖，CLOSED表示下架；当syncStatus为SUCCESS时该值一定存在，其他状态不一定存在。
        /// </summary>
        [JsonPropertyName("goods_biz_status")]
        public string GoodsBizStatus { get; set; }

        /// <summary>
        /// 商品数据同步请求处理状态： SUCCESS表示成功； FAILED表示商品信息处理失败，如商品信息审核失败；PROCESSING表示商品信息处理中。 对于同一个商品信息更新时，当返回状态为PROCESSING时需要等到最终处理成功再发起同步请求进行更新操作。
        /// </summary>
        [JsonPropertyName("sync_status")]
        public string SyncStatus { get; set; }
    }
}
