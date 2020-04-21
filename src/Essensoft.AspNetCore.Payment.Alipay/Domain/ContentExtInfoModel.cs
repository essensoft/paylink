using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// ContentExtInfoModel Data Structure.
    /// </summary>
    public class ContentExtInfoModel : AlipayObject
    {
        /// <summary>
        /// 奖品信息
        /// </summary>
        [JsonPropertyName("prize_info_list")]
        public List<ContentPrizeInfoModel> PrizeInfoList { get; set; }
    }
}
