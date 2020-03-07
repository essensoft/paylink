using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KoubeiSalesKbassetStuffFeedbackstockorderSyncModel Data Structure.
    /// </summary>
    public class KoubeiSalesKbassetStuffFeedbackstockorderSyncModel : AlipayObject
    {
        /// <summary>
        /// erp订单号
        /// </summary>
        [JsonPropertyName("erp_order")]
        public string ErpOrder { get; set; }

        /// <summary>
        /// 扩展字段
        /// </summary>
        [JsonPropertyName("ext_info")]
        public string ExtInfo { get; set; }

        /// <summary>
        /// 反馈类型  取消入库单：CANCEL_STOCK_IN_ORDER  取消出库单：CANCEL_STOCK_OUT_ORDER
        /// </summary>
        [JsonPropertyName("feedback_type")]
        public string FeedbackType { get; set; }
    }
}
