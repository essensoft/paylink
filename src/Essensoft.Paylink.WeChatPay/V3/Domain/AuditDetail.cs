using System.Text.Json.Serialization;

namespace Essensoft.Paylink.WeChatPay.V3.Domain
{
    /// <summary>
    /// 驳回原因详情
    /// </summary>
    public class AuditDetail : WeChatPayObject
    {
        /// <summary>
        /// 字段名
        /// </summary>
        /// <remarks>
        /// 提交申请单的资料项字段名
        /// <para>示例值：id_card_copy</para>
        /// </remarks>
        [JsonPropertyName("field")]
        public string Field { get; set; }

        /// <summary>
        /// 字段名称
        /// </summary>
        /// <remarks>
        /// 提交申请单的资料项字段名称
        /// <para>示例值：身份证复印件</para>
        /// </remarks>
        [JsonPropertyName("field_name")]
        public string FieldName { get; set; }

        /// <summary>
        /// 驳回原因
        /// </summary>
        /// <remarks>
        /// 提交资料项被驳回的原因。
        /// <para>示例值：身份证背面识别失败，请上传更清晰的身份证图片。</para>
        /// </remarks>
        [JsonPropertyName("reject_reason")]
        public string RejectReason { get; set; }
    }
}
