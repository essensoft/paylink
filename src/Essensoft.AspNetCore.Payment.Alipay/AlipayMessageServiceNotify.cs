using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay
{
    /// <summary>
    /// Alipay 消息服务通知对象(From蚂蚁)
    /// </summary>
    public class AlipayMessageServiceNotify : AlipayNotify
    {
        /// <summary>
        /// 通知ID
        /// </summary>
        [JsonPropertyName("notify_id")]
        public string NotifyId { get; set; }

        /// <summary>
        /// 消息发送时的服务端时间
        /// </summary>
        [JsonPropertyName("utc_timestamp")]
        public string UtcTimestamp { get; set; }

        /// <summary>
        /// 消息接口名称
        /// </summary>
        [JsonPropertyName("msg_method")]
        public string MsgMethod { get; set; }

        /// <summary>
        /// 消息接受方的应用id
        /// </summary>
        [JsonPropertyName("app_id")]
        public string AppId { get; set; }

        /// <summary>
        /// 消息类型。目前支持类型：sys：系统消息；usr，用户消息；app，应用消息
        /// </summary>
        [JsonPropertyName("msg_type")]
        public string MsgType { get; set; }

        /// <summary>
        /// 消息归属的商户支付宝uid。用户消息和应用消息时非空
        /// </summary>
        [JsonPropertyName("msg_uid")]
        public string MsgUid { get; set; }

        /// <summary>
        /// 消息归属方的应用id。应用消息时非空
        /// </summary>
        [JsonPropertyName("msg_app_id")]
        public string MsgAppId { get; set; }

        /// <summary>
        /// 版本号(1.1版本为标准消息)
        /// </summary>
        [JsonPropertyName("version")]
        public string Version { get; set; }

        /// <summary>
        /// 消息报文
        /// </summary>
        [JsonPropertyName("biz_content")]
        public string BizContent { get; set; }

        /// <summary>
        /// 签名
        /// </summary>
        [JsonPropertyName("sign")]
        public string Sign { get; set; }

        /// <summary>
        /// 签名类型
        /// </summary>
        [JsonPropertyName("sign_type")]
        public string SignType { get; set; }

        /// <summary>
        /// 加密算法	
        /// </summary>
        [JsonPropertyName("encrypt_type")]
        public string EncryptType { get; set; }

        /// <summary>
        /// 编码集，该字符集为验签和解密所需要的字符集	
        /// </summary>
        [JsonPropertyName("charset")]
        public string Charset { get; set; }

        /// <summary>
        /// [1.0版本老协议参数]通知类型，1.1接口没有该参数	
        /// </summary>
        [JsonPropertyName("notify_type")]
        public string NotifyType { get; set; }

        /// <summary>
        /// [1.0版本老协议参数]通知时间，北京时区，时间格式为：yyyy-MM-dd HH:mm:ss，如果服务器部署在国外请注意做时区转换。若version=1.1则可以使用utc_timestamp识别时间	
        /// </summary>
        [JsonPropertyName("notify_time")]
        public string NotifyTime { get; set; }

        /// <summary>
        /// [1.0版本老协议参数]授权方的应用id	
        /// </summary>
        [JsonPropertyName("auth_app_id")]
        public string AuthAppId { get; set; }
    }
}
