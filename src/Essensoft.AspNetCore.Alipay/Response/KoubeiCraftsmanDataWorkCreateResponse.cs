using Newtonsoft.Json;
using System.Collections.Generic;
using Essensoft.AspNetCore.Alipay.Domain;

namespace Essensoft.AspNetCore.Alipay.Response
{
    /// <summary>
    /// KoubeiCraftsmanDataWorkCreateResponse.
    /// </summary>
    public class KoubeiCraftsmanDataWorkCreateResponse : AlipayResponse
    {
        /// <summary>
        /// 作品id
        /// </summary>
        [JsonProperty("works")]
        public List<CraftsmanWorkOutIdOpenModel> Works { get; set; }
    }
}
