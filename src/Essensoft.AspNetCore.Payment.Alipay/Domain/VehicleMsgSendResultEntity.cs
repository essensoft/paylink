using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// VehicleMsgSendResultEntity Data Structure.
    /// </summary>
    public class VehicleMsgSendResultEntity : AlipayObject
    {
        /// <summary>
        /// identity字段：值为不大于64位的保证唯一的字符串；该字段用于保证消息唯一性，防止消息重复推送，相当于业务流水号，由接入方自行生成
        /// </summary>
        [JsonPropertyName("out_msg_id")]
        public string OutMsgId { get; set; }

        /// <summary>
        /// 消息如果投递失败的提示信息
        /// </summary>
        [JsonPropertyName("result")]
        public string Result { get; set; }

        /// <summary>
        /// 投递结果，车主服务是否成功接收消息请求
        /// </summary>
        [JsonPropertyName("success")]
        public bool Success { get; set; }
    }
}
