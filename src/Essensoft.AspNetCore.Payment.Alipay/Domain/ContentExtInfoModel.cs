using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// ContentExtInfoModel Data Structure.
    /// </summary>
    [Serializable]
    public class ContentExtInfoModel : AlipayObject
    {
        /// <summary>
        /// 奖品信息
        /// </summary>
        [JsonProperty("prize_info_list")]
        public List<ContentPrizeInfoModel> PrizeInfoList { get; set; }
    }
}
