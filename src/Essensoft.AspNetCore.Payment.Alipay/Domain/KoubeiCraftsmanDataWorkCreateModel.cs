using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KoubeiCraftsmanDataWorkCreateModel Data Structure.
    /// </summary>
    public class KoubeiCraftsmanDataWorkCreateModel : AlipayObject
    {
        /// <summary>
        /// 服务商、服务商员工、商户、商户员工等口碑角色操作时必填，对应为 koubei.member.data.oauth.query 中的 auth_code，默认有效期24小时；ISV自身角色操作的时候，无需传该参数
        /// </summary>
        [JsonPropertyName("auth_code")]
        public string AuthCode { get; set; }

        /// <summary>
        /// 口碑手艺人id。是创建手艺人接口koubei.craftsman.data.provider.create返回的craftsman_id，或通过查询手艺人信息接口koubei.craftsman.data.provider查询craftsman_id
        /// </summary>
        [JsonPropertyName("craftsman_id")]
        public string CraftsmanId { get; set; }

        /// <summary>
        /// 作品所属门店id列表。可通过批量查询手艺人信息接口koubei.craftsman.data.provider.batchquery，查询手艺人所属的门店的shop_id。
        /// </summary>
        [JsonPropertyName("shop_ids")]
        public List<string> ShopIds { get; set; }

        /// <summary>
        /// 作品列表
        /// </summary>
        [JsonPropertyName("works")]
        public List<CraftsmanWorkCreateOpenModel> Works { get; set; }
    }
}
