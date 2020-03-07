using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayOpenAppPropertyMessageSendModel Data Structure.
    /// </summary>
    public class AlipayOpenAppPropertyMessageSendModel : AlipayObject
    {
        /// <summary>
        /// 业务ID，作为消息的唯一标识，服务端会按照此参数做幂等处理
        /// </summary>
        [JsonPropertyName("biz_id")]
        public string BizId { get; set; }

        /// <summary>
        /// 物业消息对应的小区名称
        /// </summary>
        [JsonPropertyName("community")]
        public string Community { get; set; }

        /// <summary>
        /// 消息模板：您2019.01.01到2019.02.01的物业费账单为500.00元，请及时缴纳。 content以map形式传递关键字段值。
        /// </summary>
        [JsonPropertyName("content")]
        public string Content { get; set; }

        /// <summary>
        /// 物业消息发送时间
        /// </summary>
        [JsonPropertyName("date")]
        public string Date { get; set; }

        /// <summary>
        /// 物业消息标题
        /// </summary>
        [JsonPropertyName("title")]
        public string Title { get; set; }

        /// <summary>
        /// 物业消息类型：代收费账单-月度通知(CHARGE_BILL_MONTH)、物业费账单-月度通知(PROPERTY_BILL_MONTH)、物业费账单-逾期通知(PROPERTY_BILL_OVERDUE)、工单开始处理(ORDER_START)、工单预计服务时间（ORDER_SERVICE_TIME）、工单被关闭(ORDER_CLOSE)
        /// </summary>
        [JsonPropertyName("type")]
        public string Type { get; set; }

        /// <summary>
        /// 物业消息推送的用户支付宝ID
        /// </summary>
        [JsonPropertyName("uid")]
        public string Uid { get; set; }

        /// <summary>
        /// 物业消息对应的url地址，可引导用户跳转
        /// </summary>
        [JsonPropertyName("url")]
        public string Url { get; set; }
    }
}
