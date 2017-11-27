using Newtonsoft.Json;
using System.Collections.Generic;
using Essensoft.AspNetCore.Alipay.Domain;

namespace Essensoft.AspNetCore.Alipay.Response
{
    /// <summary>
    /// AlipayOpenPublicAdvertBatchqueryResponse.
    /// </summary>
    public class AlipayOpenPublicAdvertBatchqueryResponse : AlipayResponse
    {
        /// <summary>
        /// 广告位list ,目前只有一个广告位
        /// </summary>
        [JsonProperty("advert_list")]
        public List<Advert> AdvertList { get; set; }
    }
}
