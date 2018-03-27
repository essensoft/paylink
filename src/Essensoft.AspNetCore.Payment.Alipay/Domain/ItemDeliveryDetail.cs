using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// ItemDeliveryDetail Data Structure.
    /// </summary>
    public class ItemDeliveryDetail : AlipayObject
    {
        /// <summary>
        /// 订单明细ID
        /// </summary>
        [JsonProperty("assign_item_id")]
        public string AssignItemId { get; set; }

        /// <summary>
        /// 物流公司code, 比如: SF-顺丰, POST-中国邮政, CAINIAO-菜鸟.
        /// </summary>
        [JsonProperty("logistic_code")]
        public string LogisticCode { get; set; }

        /// <summary>
        /// 物流公司名称
        /// </summary>
        [JsonProperty("logistics_name")]
        public string LogisticsName { get; set; }

        /// <summary>
        /// 物流订单号
        /// </summary>
        [JsonProperty("logistics_no")]
        public string LogisticsNo { get; set; }
    }
}
