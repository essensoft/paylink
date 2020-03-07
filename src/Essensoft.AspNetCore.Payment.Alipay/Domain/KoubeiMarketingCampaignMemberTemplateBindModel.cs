using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KoubeiMarketingCampaignMemberTemplateBindModel Data Structure.
    /// </summary>
    public class KoubeiMarketingCampaignMemberTemplateBindModel : AlipayObject
    {
        /// <summary>
        /// 将门店绑定到会员模板上，跟remove_shop_ids不可同时为空
        /// </summary>
        [JsonPropertyName("add_shop_ids")]
        public List<string> AddShopIds { get; set; }

        /// <summary>
        /// 会员模板id
        /// </summary>
        [JsonPropertyName("member_template_id")]
        public string MemberTemplateId { get; set; }

        /// <summary>
        /// 将门店与会员模板解绑，跟add_shop_ids不可同时为空
        /// </summary>
        [JsonPropertyName("remove_shop_ids")]
        public List<string> RemoveShopIds { get; set; }

        /// <summary>
        /// 请求ID，由开发者生成并保证唯一性
        /// </summary>
        [JsonPropertyName("request_id")]
        public string RequestId { get; set; }
    }
}
