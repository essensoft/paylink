using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.WeChatPay.V3.Domain
{
    /// <summary>
    /// 驳回原因详情
    /// </summary>
    public class AuditDetail : WeChatPayObject
    {
        /// <summary>
        /// 字段名
        /// 提交申请单的资料项字段名
        /// 示例值：id_card_copy
        /// </summary>
        [JsonPropertyName("field")]
        public string Field { get; set; }

        /// <summary>
        /// 字段名称
        /// 提交申请单的资料项字段名称
        /// 示例值：身份证复印件
        /// </summary>
        [JsonPropertyName("field_name")]
        public string FieldName { get; set; }

        /// <summary>
        /// 驳回原因
        /// 提交资料项被驳回的原因。
        /// 示例值：身份证背面识别失败，请上传更清晰的身份证图片。
        /// </summary>
        [JsonPropertyName("reject_reason")]
        public string RejectReason { get; set; }
    }
}
