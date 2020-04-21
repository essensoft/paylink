using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// RoyaltyInfo Data Structure.
    /// </summary>
    public class RoyaltyInfo : AlipayObject
    {
        /// <summary>
        /// 分账明细的信息，可以描述多条分账指令，json数组。
        /// </summary>
        [JsonPropertyName("royalty_detail_infos")]
        public List<RoyaltyDetailInfos> RoyaltyDetailInfos { get; set; }

        /// <summary>
        /// 分账类型  卖家的分账类型，目前只支持传入ROYALTY（普通分账类型）。
        /// </summary>
        [JsonPropertyName("royalty_type")]
        public string RoyaltyType { get; set; }
    }
}
