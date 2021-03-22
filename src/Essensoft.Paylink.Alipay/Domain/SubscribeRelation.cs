using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// SubscribeRelation Data Structure.
    /// </summary>
    public class SubscribeRelation : AlipayObject
    {
        /// <summary>
        /// 订阅保持状态，下次静默订阅的时的状态。0:保持订阅，1:保持拒绝订阅
        /// </summary>
        [JsonPropertyName("keep_state")]
        public string KeepState { get; set; }

        /// <summary>
        /// 模板是否展示在订阅组件中。ture:订阅组件中展示查询的模板，false:订阅组件中不展示模板
        /// </summary>
        [JsonPropertyName("show")]
        public bool Show { get; set; }

        /// <summary>
        /// 订阅状态。0:拒绝订阅，1:订阅
        /// </summary>
        [JsonPropertyName("subscribe_state")]
        public string SubscribeState { get; set; }

        /// <summary>
        /// 消息模板的订阅类型。longterm:长期性订阅，onetime:一次性订阅
        /// </summary>
        [JsonPropertyName("subscribe_type")]
        public string SubscribeType { get; set; }

        /// <summary>
        /// 消息模板id
        /// </summary>
        [JsonPropertyName("template_id")]
        public string TemplateId { get; set; }
    }
}
