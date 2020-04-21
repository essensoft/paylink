using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KbAdvertAdvSingleVoucherResponse Data Structure.
    /// </summary>
    public class KbAdvertAdvSingleVoucherResponse : AlipayObject
    {
        /// <summary>
        /// 广告内容模型
        /// </summary>
        [JsonPropertyName("adv_content_list")]
        public List<KbAdvertAdvContentResponse> AdvContentList { get; set; }

        /// <summary>
        /// 广告内容（广告内容请使用新的属性adv_content_list，此属性仍会保留）
        /// </summary>
        [JsonPropertyName("content")]
        public KbAdvertAdvContent Content { get; set; }

        /// <summary>
        /// 券标的
        /// </summary>
        [JsonPropertyName("voucher")]
        public KbAdvertSubjectVoucherResponse Voucher { get; set; }
    }
}
