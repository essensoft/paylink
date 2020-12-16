using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayCommerceEducateTuitioncodeApplySendModel Data Structure.
    /// </summary>
    public class AlipayCommerceEducateTuitioncodeApplySendModel : AlipayObject
    {
        /// <summary>
        /// 外部申请单号
        /// </summary>
        [JsonPropertyName("out_apply_id")]
        public string OutApplyId { get; set; }

        /// <summary>
        /// 商户账户
        /// </summary>
        [JsonPropertyName("smid")]
        public string Smid { get; set; }
    }
}
