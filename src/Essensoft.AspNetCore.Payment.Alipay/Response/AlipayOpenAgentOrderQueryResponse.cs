using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayOpenAgentOrderQueryResponse.
    /// </summary>
    public class AlipayOpenAgentOrderQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 代理创建的应用ID，如果有代理商户创建应用，商户确认成功后，才返回应用ID，否则不返回。
        /// </summary>
        [JsonPropertyName("agent_app_id")]
        public string AgentAppId { get; set; }

        /// <summary>
        /// 只有申请单状态在MERCHANT_CONFIRM状态下，才会返回商户确认签约链接
        /// </summary>
        [JsonPropertyName("confirm_url")]
        public string ConfirmUrl { get; set; }

        /// <summary>
        /// 商户pid
        /// </summary>
        [JsonPropertyName("merchant_pid")]
        public string MerchantPid { get; set; }

        /// <summary>
        /// 支付宝商户入驻申请单状态，申请单状态包括：  MERCHANT_INFO_HOLD=暂存，提交事务出现业务校验异常时，会暂存申请单信息，可以调用业务接口修正参数，并重新提交  MERCHANT_AUDITING=审核中，申请信息正在人工审核中  MERCHANT_CONFIRM=待商户确认，申请信息审核通过，等待联系人确认签约或授权  MERCHANT_CONFIRM_SUCCESS=商户确认成功，商户同意签约或授权  MERCHANT_CONFIRM_TIME_OUT=商户超时未确认，如果商户受到确认信息15天内未确认，则需要重新提交申请信息  MERCHANT_APPLY_ORDER_CANCELED=审核失败或商户拒绝，申请信息审核被驳回，或者商户选择拒绝签约或授权
        /// </summary>
        [JsonPropertyName("order_status")]
        public string OrderStatus { get; set; }

        /// <summary>
        /// 审核失败的拒绝原因，只有审核失败才会返回该值
        /// </summary>
        [JsonPropertyName("reject_reason")]
        public string RejectReason { get; set; }
    }
}
