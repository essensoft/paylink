using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AssetDeliveryDetail Data Structure.
    /// </summary>
    public class AssetDeliveryDetail : AlipayObject
    {
        /// <summary>
        /// 配送数量
        /// </summary>
        [JsonPropertyName("amount")]
        public string Amount { get; set; }

        /// <summary>
        /// 配送订单ID
        /// </summary>
        [JsonPropertyName("assign_item_id")]
        public string AssignItemId { get; set; }

        /// <summary>
        /// 由供应商自定义的分批反馈批次号，用于保持幂等，此值不传则需要按整批反馈.(由字母,数字,下划线组成)
        /// </summary>
        [JsonPropertyName("batch_no")]
        public string BatchNo { get; set; }

        /// <summary>
        /// JSON格式扩展信息
        /// </summary>
        [JsonPropertyName("ext_info")]
        public string ExtInfo { get; set; }

        /// <summary>
        /// 物流单信息
        /// </summary>
        [JsonPropertyName("logistics_infos")]
        public List<LogisticsInfo> LogisticsInfos { get; set; }
    }
}
