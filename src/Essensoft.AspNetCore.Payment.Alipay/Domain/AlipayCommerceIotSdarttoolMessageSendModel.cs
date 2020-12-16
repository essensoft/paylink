using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayCommerceIotSdarttoolMessageSendModel Data Structure.
    /// </summary>
    public class AlipayCommerceIotSdarttoolMessageSendModel : AlipayObject
    {
        /// <summary>
        /// 消息是否必达(immediate_msg为false时此字段设置有效)，消息过期时间顺延3*24h. 建议使用expire_time设置消息过期时间
        /// </summary>
        [JsonPropertyName("bi_da")]
        public bool BiDa { get; set; }

        /// <summary>
        /// 设备查询条件类型 ；SUPPLIERID_SN:supplierid+sn ;  ITEMID_SN:itemid + sn; SN:sn
        /// </summary>
        [JsonPropertyName("device_query_type")]
        public string DeviceQueryType { get; set; }

        /// <summary>
        /// 是否即时消息; true-校验设备是否在线，false-不校验设备是否在线
        /// </summary>
        [JsonPropertyName("immediate_msg")]
        public bool ImmediateMsg { get; set; }

        /// <summary>
        /// 产品ID
        /// </summary>
        [JsonPropertyName("item_id")]
        public string ItemId { get; set; }

        /// <summary>
        /// 消息内容(xpaas_common:{"contentParams":["消息内容"]};audio_msg:{"contentParams":["语音内容"]};cloud_print:{"contentParams":["打印内容"],"target":"打印编号-可选默认第一个","instructionFormat":"template或cmd"})
        /// </summary>
        [JsonPropertyName("msg_content")]
        public string MsgContent { get; set; }

        /// <summary>
        /// 消息内容格式
        /// </summary>
        [JsonPropertyName("msg_content_type")]
        public string MsgContentType { get; set; }

        /// <summary>
        /// 消息过期时间戳(ms)， 默认为当前时间顺延24h有效。当设备在线时消息服务过期之前尝试推送。最大过期时间顺延3*24h
        /// </summary>
        [JsonPropertyName("msg_expire")]
        public long MsgExpire { get; set; }

        /// <summary>
        /// 消息优先级（immediate_msg为false此字段设置有效）数字越大优先发送。
        /// </summary>
        [JsonPropertyName("msg_priority")]
        public long MsgPriority { get; set; }

        /// <summary>
        /// 消息类型：xpaas_common-小程序通用消息
        /// </summary>
        [JsonPropertyName("msg_type")]
        public string MsgType { get; set; }

        /// <summary>
        /// 服务ID，当小程序消费消息时必传(传入的是小程序ID)
        /// </summary>
        [JsonPropertyName("service_id")]
        public string ServiceId { get; set; }

        /// <summary>
        /// 设备sn号
        /// </summary>
        [JsonPropertyName("sn")]
        public string Sn { get; set; }

        /// <summary>
        /// 厂商ID
        /// </summary>
        [JsonPropertyName("supplier_id")]
        public string SupplierId { get; set; }
    }
}
