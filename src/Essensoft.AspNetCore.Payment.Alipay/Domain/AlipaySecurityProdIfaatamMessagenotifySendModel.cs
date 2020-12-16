using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipaySecurityProdIfaatamMessagenotifySendModel Data Structure.
    /// </summary>
    public class AlipaySecurityProdIfaatamMessagenotifySendModel : AlipayObject
    {
        /// <summary>
        /// 业务操作类型
        /// </summary>
        [JsonPropertyName("biz_type")]
        public string BizType { get; set; }

        /// <summary>
        /// ISV接入的汽车终端(T-box)唯一标示,表明消息是由该终端发出
        /// </summary>
        [JsonPropertyName("box_did")]
        public string BoxDid { get; set; }

        /// <summary>
        /// business_id业务流水号+唯一+用于和ISV厂商服务端唯一确定一笔业务
        /// </summary>
        [JsonPropertyName("business_id")]
        public string BusinessId { get; set; }

        /// <summary>
        /// 商户ID
        /// </summary>
        [JsonPropertyName("partner_id")]
        public string PartnerId { get; set; }

        /// <summary>
        /// 汽车终端发起的消息通知内容,包含车辆的模块,当前的状态,和状态描述信息
        /// </summary>
        [JsonPropertyName("vehicle_message_info")]
        public VehicleMessageInfo VehicleMessageInfo { get; set; }
    }
}
