using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// ErrorDeliveryConfig Data Structure.
    /// </summary>
    public class ErrorDeliveryConfig : AlipayObject
    {
        /// <summary>
        /// 投放配置
        /// </summary>
        [JsonPropertyName("delivery_config")]
        public DeliveryConfig DeliveryConfig { get; set; }

        /// <summary>
        /// 错误码。针对单个投放，具体的错误原因。  枚举值： UNKNOWN_EXCEPTION: 未知异常，可重试。 ACTIVITY_STATUS_NOT_ACTIVE:  活动状态未激活，不可重试。 ACTIVITY_OVERDUE:活动已过期，不可重试。 DELIVERY_VALIDATE_ERROR:投放校验不通过，不可重试。 DELIVERY_OPERATE_ERROR: 投放操作失败，不可重试。 BOOTH_CHANNEL_NOT_EXIST:渠道不存在，不可重试。
        /// </summary>
        [JsonPropertyName("error_code")]
        public string ErrorCode { get; set; }

        /// <summary>
        /// 详细的投放错误信息。用于判断具体的错误信息。
        /// </summary>
        [JsonPropertyName("error_msg")]
        public string ErrorMsg { get; set; }
    }
}
