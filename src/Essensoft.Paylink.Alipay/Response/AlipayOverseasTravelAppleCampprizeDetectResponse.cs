using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.Paylink.Alipay.Domain;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// AlipayOverseasTravelAppleCampprizeDetectResponse.
    /// </summary>
    public class AlipayOverseasTravelAppleCampprizeDetectResponse : AlipayResponse
    {
        /// <summary>
        /// 奖品简要信息列表，一定不为null，但是size可以为0
        /// </summary>
        [JsonPropertyName("prizes")]
        public List<PrizeLiteInfo> Prizes { get; set; }
    }
}
