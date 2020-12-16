using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayIserviceItaskMerchantRecordSyncModel Data Structure.
    /// </summary>
    public class AlipayIserviceItaskMerchantRecordSyncModel : AlipayObject
    {
        /// <summary>
        /// 业务标识
        /// </summary>
        [JsonPropertyName("biz_code")]
        public string BizCode { get; set; }

        /// <summary>
        /// 业务数据主键
        /// </summary>
        [JsonPropertyName("biz_id")]
        public string BizId { get; set; }

        /// <summary>
        /// 消费用户id
        /// </summary>
        [JsonPropertyName("buyer_id")]
        public string BuyerId { get; set; }

        /// <summary>
        /// 用户信息详情
        /// </summary>
        [JsonPropertyName("buyer_info")]
        public BuyerInfo BuyerInfo { get; set; }

        /// <summary>
        /// 内容扩展参数
        /// </summary>
        [JsonPropertyName("content")]
        public HomeNormalApiContent Content { get; set; }

        /// <summary>
        /// 如果buyer_id是支付宝userId...
        /// </summary>
        [JsonPropertyName("is_alipay_user")]
        public string IsAlipayUser { get; set; }

        /// <summary>
        /// 用户是否授权
        /// </summary>
        [JsonPropertyName("is_authorize")]
        public string IsAuthorize { get; set; }

        /// <summary>
        /// 消息时间戳，毫秒级别
        /// </summary>
        [JsonPropertyName("msg_time")]
        public string MsgTime { get; set; }

        /// <summary>
        /// 业务数据订单状态
        /// </summary>
        [JsonPropertyName("node_code")]
        public string NodeCode { get; set; }
    }
}
