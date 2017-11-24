using Newtonsoft.Json;
using System.Collections.Generic;
using Essensoft.AspNetCore.Alipay.Domain;

namespace Essensoft.AspNetCore.Alipay.Response
{
    /// <summary>
    /// AlipayUserAccountFreezeGetResponse.
    /// </summary>
    public class AlipayUserAccountFreezeGetResponse : AlipayResponse
    {
        /// <summary>
        /// 冻结金额列表
        /// </summary>
        [JsonProperty("freeze_items")]
        public List<AccountFreeze> FreezeItems { get; set; }

        /// <summary>
        /// 冻结总条数
        /// </summary>
        [JsonProperty("total_results")]
        public string TotalResults { get; set; }
    }
}
