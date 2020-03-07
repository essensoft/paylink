using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayOpenMiniActivityGiftQueryModel Data Structure.
    /// </summary>
    public class AlipayOpenMiniActivityGiftQueryModel : AlipayObject
    {
        /// <summary>
        /// 小程序活动id
        /// </summary>
        [JsonPropertyName("template_id")]
        public string TemplateId { get; set; }

        /// <summary>
        /// 券跳转地址类型
        /// </summary>
        [JsonPropertyName("voucher_jump_type")]
        public string VoucherJumpType { get; set; }
    }
}
