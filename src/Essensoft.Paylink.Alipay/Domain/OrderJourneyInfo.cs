using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// OrderJourneyInfo Data Structure.
    /// </summary>
    public class OrderJourneyInfo : AlipayObject
    {
        /// <summary>
        /// 操作动作 -DELETE 删除，删除后的行程不再展示
        /// </summary>
        [JsonPropertyName("action")]
        public string Action { get; set; }

        /// <summary>
        /// 扩展信息
        /// </summary>
        [JsonPropertyName("ext_info")]
        public List<OrderExtInfo> ExtInfo { get; set; }

        /// <summary>
        /// 行程创建时间
        /// </summary>
        [JsonPropertyName("journey_create_time")]
        public string JourneyCreateTime { get; set; }

        /// <summary>
        /// 行程描述
        /// </summary>
        [JsonPropertyName("journey_desc")]
        public string JourneyDesc { get; set; }

        /// <summary>
        /// 行程元素列表
        /// </summary>
        [JsonPropertyName("journey_elements")]
        public List<OrderJourneyElement> JourneyElements { get; set; }

        /// <summary>
        /// 描述本行程为整个行程中的第几程
        /// </summary>
        [JsonPropertyName("journey_index")]
        public string JourneyIndex { get; set; }

        /// <summary>
        /// 行程修改时间
        /// </summary>
        [JsonPropertyName("journey_modify_time")]
        public string JourneyModifyTime { get; set; }

        /// <summary>
        /// 商户行程单号 注：同一个pid下的行程单号需唯一。同一个pid下外部行程单号唯一
        /// </summary>
        [JsonPropertyName("merchant_journey_no")]
        public string MerchantJourneyNo { get; set; }

        /// <summary>
        /// 行程状态 注：行程状态必须与支付宝侧进行约定
        /// </summary>
        [JsonPropertyName("status")]
        public string Status { get; set; }

        /// <summary>
        /// 行程状态描述
        /// </summary>
        [JsonPropertyName("status_desc")]
        public string StatusDesc { get; set; }

        /// <summary>
        /// 行程子类型
        /// </summary>
        [JsonPropertyName("sub_type")]
        public string SubType { get; set; }

        /// <summary>
        /// 行程标题
        /// </summary>
        [JsonPropertyName("title")]
        public string Title { get; set; }

        /// <summary>
        /// 行程类型
        /// </summary>
        [JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
