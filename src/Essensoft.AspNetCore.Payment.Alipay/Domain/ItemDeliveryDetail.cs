using System;
using Newtonsoft.Json;
using System.Xml.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// ItemDeliveryDetail Data Structure.
    /// </summary>
    [Serializable]
    public class ItemDeliveryDetail : AlipayObject
    {
        /// <summary>
        /// 订单明细ID
        /// </summary>
        [JsonProperty("assign_item_id")]
        [XmlElement("assign_item_id")]
        public string AssignItemId { get; set; }

        /// <summary>
        /// 物流公司code, 比如: SF-顺丰, POST-中国邮政, CAINIAO-菜鸟.
        /// </summary>
        [JsonProperty("logistic_code")]
        [XmlElement("logistic_code")]
        public string LogisticCode { get; set; }

        /// <summary>
        /// 物流公司名称
        /// </summary>
        [JsonProperty("logistics_name")]
        [XmlElement("logistics_name")]
        public string LogisticsName { get; set; }

        /// <summary>
        /// 物流订单号
        /// </summary>
        [JsonProperty("logistics_no")]
        [XmlElement("logistics_no")]
        public string LogisticsNo { get; set; }
    }
}
