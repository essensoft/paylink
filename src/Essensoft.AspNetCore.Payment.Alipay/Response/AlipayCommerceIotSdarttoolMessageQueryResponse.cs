using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayCommerceIotSdarttoolMessageQueryResponse.
    /// </summary>
    public class AlipayCommerceIotSdarttoolMessageQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 消息消费返回码，不用的消息类型返回码不一样
        /// </summary>
        [JsonPropertyName("consume_err_code")]
        public string ConsumeErrCode { get; set; }

        /// <summary>
        /// 消息消费错误原因
        /// </summary>
        [JsonPropertyName("consume_err_msg")]
        public string ConsumeErrMsg { get; set; }

        /// <summary>
        /// 消息消费状态1-成功 2-失败
        /// </summary>
        [JsonPropertyName("consume_state")]
        public long ConsumeState { get; set; }

        /// <summary>
        /// 消息投递次数
        /// </summary>
        [JsonPropertyName("deliver_cnt")]
        public long DeliverCnt { get; set; }

        /// <summary>
        /// 消息投递状态 1: 未投递 2: 投递中 3: 投递成功 4: 投递失败 5: 消息失效不再发送
        /// </summary>
        [JsonPropertyName("deliver_status")]
        public string DeliverStatus { get; set; }

        /// <summary>
        /// 消息最后一次发送时间
        /// </summary>
        [JsonPropertyName("last_deliver_at")]
        public long LastDeliverAt { get; set; }

        /// <summary>
        /// 消息确认消费时间(ms)
        /// </summary>
        [JsonPropertyName("msg_ack_time")]
        public long MsgAckTime { get; set; }

        /// <summary>
        /// 消息必达类型 1-非必达; 2-必达.
        /// </summary>
        [JsonPropertyName("msg_bida")]
        public long MsgBida { get; set; }

        /// <summary>
        /// 消息过期时间(ms)
        /// </summary>
        [JsonPropertyName("msg_expire_time")]
        public long MsgExpireTime { get; set; }

        /// <summary>
        /// 消息创建时间(ms)
        /// </summary>
        [JsonPropertyName("msg_gmt_create")]
        public long MsgGmtCreate { get; set; }

        /// <summary>
        /// 消息投递优先级
        /// </summary>
        [JsonPropertyName("msg_priority")]
        public long MsgPriority { get; set; }
    }
}
