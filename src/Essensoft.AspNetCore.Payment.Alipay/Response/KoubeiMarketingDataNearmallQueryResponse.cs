using System.Collections.Generic;
using Essensoft.AspNetCore.Payment.Alipay.Domain;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// KoubeiMarketingDataNearmallQueryResponse.
    /// </summary>
    public class KoubeiMarketingDataNearmallQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 商圈信息
        /// </summary>
        [JsonProperty("near_mall_bos")]
        public List<NearMallBo> NearMallBos { get; set; }
    }
}
