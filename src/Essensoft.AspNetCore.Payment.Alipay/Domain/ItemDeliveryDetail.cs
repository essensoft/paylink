using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// ItemDeliveryDetail Data Structure.
    /// </summary>
    public class ItemDeliveryDetail : AlipayObject
    {
        /// <summary>
        /// 已生产数量, 分批反馈时候必传.
        /// </summary>
        [JsonPropertyName("amount")]
        public string Amount { get; set; }

        /// <summary>
        /// 订单明细ID
        /// </summary>
        [JsonPropertyName("assign_item_id")]
        public string AssignItemId { get; set; }

        /// <summary>
        /// 由供应商自定义的分批反馈批次号，用于保持幂等，此值不传则需要按整批反馈.(由字母,数字,下划线组成)
        /// </summary>
        [JsonPropertyName("batch_no")]
        public string BatchNo { get; set; }

        /// <summary>
        /// 物流公司code, 比如: SF-顺丰, POST-中国邮政, CAINIAO-菜鸟.
        /// </summary>
        [JsonPropertyName("logistic_code")]
        public string LogisticCode { get; set; }

        /// <summary>
        /// 物流公司名称
        /// </summary>
        [JsonPropertyName("logistics_name")]
        public string LogisticsName { get; set; }

        /// <summary>
        /// 物流订单号
        /// </summary>
        [JsonPropertyName("logistics_no")]
        public string LogisticsNo { get; set; }
    }
}
