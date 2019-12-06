using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KoubeiAdvertCommissionSpecialadvcontentModifyModel Data Structure.
    /// </summary>
    public class KoubeiAdvertCommissionSpecialadvcontentModifyModel : AlipayObject
    {
        /// <summary>
        /// 广告ID
        /// </summary>
        [JsonPropertyName("adv_id")]
        public string AdvId { get; set; }

        /// <summary>
        /// 渠道ID（如果修改的是广告的默认主推广的内容，则不传渠道ID；如果修改的是广告的指定投放渠道的内容，则传指定渠道的ID）
        /// </summary>
        [JsonPropertyName("channel_id")]
        public string ChannelId { get; set; }

        /// <summary>
        /// 创建或者删除广告内容的请求参数List
        /// </summary>
        [JsonPropertyName("content_list")]
        public List<KbAdvertSpecialAdvContentRequest> ContentList { get; set; }

        /// <summary>
        /// 特殊广告内容的修改枚举类型：  create：表示创建特殊广告内容  delete：表示删除特殊广告内容
        /// </summary>
        [JsonPropertyName("modify_type")]
        public string ModifyType { get; set; }
    }
}
