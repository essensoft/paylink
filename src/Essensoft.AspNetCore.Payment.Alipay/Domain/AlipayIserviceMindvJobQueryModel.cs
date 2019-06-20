using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayIserviceMindvJobQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayIserviceMindvJobQueryModel : AlipayObject
    {
        /// <summary>
        /// 问卷id_系统内唯一_根据问卷id查询问卷相关信息
        /// </summary>
        [JsonProperty("id")]
        public long Id { get; set; }
    }
}
