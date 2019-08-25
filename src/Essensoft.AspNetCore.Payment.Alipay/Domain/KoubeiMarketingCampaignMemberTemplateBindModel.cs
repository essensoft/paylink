using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KoubeiMarketingCampaignMemberTemplateBindModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiMarketingCampaignMemberTemplateBindModel : AlipayObject
    {
        /// <summary>
        /// 将门店绑定到会员模板上，跟remove_shop_ids不可同时为空
        /// </summary>
        [JsonProperty("add_shop_ids")]
        public List<string> AddShopIds { get; set; }

        /// <summary>
        /// 会员模板id
        /// </summary>
        [JsonProperty("member_template_id")]
        public string MemberTemplateId { get; set; }

        /// <summary>
        /// 将门店与会员模板解绑，跟add_shop_ids不可同时为空
        /// </summary>
        [JsonProperty("remove_shop_ids")]
        public List<string> RemoveShopIds { get; set; }

        /// <summary>
        /// 请求ID，由开发者生成并保证唯一性
        /// </summary>
        [JsonProperty("request_id")]
        public string RequestId { get; set; }
    }
}
