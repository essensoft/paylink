using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.Paylink.Alipay.Domain;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// AlipayFundCouponWufuLiveAcceptResponse.
    /// </summary>
    public class AlipayFundCouponWufuLiveAcceptResponse : AlipayResponse
    {
        /// <summary>
        /// 奖品列表信息，prized=true时取第一个
        /// </summary>
        [JsonPropertyName("prize_list")]
        public List<CommonPrizeModelVo> PrizeList { get; set; }

        /// <summary>
        /// 是否中奖
        /// </summary>
        [JsonPropertyName("prized")]
        public bool Prized { get; set; }
    }
}
