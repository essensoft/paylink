using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.WeChatPay.Domain
{
    /// <summary>
    /// 支付通知报文
    /// 最新更新时间：2020.05.26
    /// https://pay.weixin.qq.com/wiki/doc/apiv3/wxpay/pay/transactions/chapter3_11.shtml
    /// </summary>
    public class WeChatPayV3NotifyCiphertext : WeChatPayObject
    {
        /// <summary>
        /// 通知ID
        /// 通知的唯一ID
        /// 示例值：EV-2018022511223320873
        /// </summary>
        [JsonPropertyName("id")]
        public string Id { get; set; }

        /// <summary>
        /// 通知创建时间
        /// 通知创建的时间，格式为yyyyMMddHHmmss
        /// 示例值：20180225112233
        /// </summary>
        [JsonPropertyName("create_time")]
        public string CreateTime { get; set; }

        /// <summary>
        /// 通知类型
        /// 通知的类型，支付成功通知的类型为TRANSACTION.SUCCESS
        /// 示例值：TRANSACTION.SUCCESS
        /// </summary>
        [JsonPropertyName("event_type")]
        public string EventType { get; set; }

        /// <summary>
        /// 通知数据类型
        /// 通知的资源数据类型，支付成功通知为encrypt-resource
        /// 示例值：encrypt-resource
        /// </summary>
        [JsonPropertyName("resource_type")]
        public string ResourceType { get; set; }

        /// <summary>
        /// 通知数据
        /// 通知资源数据
        /// json格式，见示例
        /// </summary>
        [JsonPropertyName("resource")]
        public Resource Resource { get; set; }
    }
}
