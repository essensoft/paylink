using System.Text.Json.Serialization;

namespace Essensoft.Paylink.WeChatPay.V3.Domain
{
    /// <summary>
    /// 驳回原因详情
    /// </summary>
    public class EcommerceAuditDetail : WeChatPayObject
    {
        /// <summary>
        /// 参数名称
        /// </summary>
        /// <remarks>
        /// 提交申请单的资料项名称。
        /// <para>示例值：id_card_copy</para>
        /// </remarks>
        [JsonPropertyName("param_name")]
        public string ParamName { get; set; }

        /// <summary>
        /// 参数名称
        /// </summary>
        /// <remarks>
        /// 提交资料项被驳回原因。
        /// <para>示例值：身份证背面识别失败，请上传更清晰的身份证图片</para>
        /// </remarks>
        [JsonPropertyName("reject_reason")]
        public string RejectReason { get; set; }
    }
}
