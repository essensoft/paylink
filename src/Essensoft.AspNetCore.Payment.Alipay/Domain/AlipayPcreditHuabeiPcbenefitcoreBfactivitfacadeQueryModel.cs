using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayPcreditHuabeiPcbenefitcoreBfactivitfacadeQueryModel Data Structure.
    /// </summary>
    public class AlipayPcreditHuabeiPcbenefitcoreBfactivitfacadeQueryModel : AlipayObject
    {
        /// <summary>
        /// 商户ID
        /// </summary>
        [JsonPropertyName("partner_id")]
        public string PartnerId { get; set; }

        /// <summary>
        /// 活动类型，传空默认查所有
        /// </summary>
        [JsonPropertyName("product_ids")]
        public List<string> ProductIds { get; set; }

        /// <summary>
        /// 来源系统
        /// </summary>
        [JsonPropertyName("request_from")]
        public string RequestFrom { get; set; }

        /// <summary>
        /// 查询对应状态活动，默认所有状态活动类型
        /// </summary>
        [JsonPropertyName("status")]
        public List<string> Status { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [JsonPropertyName("user_id")]
        public string UserId { get; set; }
    }
}
