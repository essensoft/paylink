using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayIserviceMindvSnapshotQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayIserviceMindvSnapshotQueryModel : AlipayObject
    {
        /// <summary>
        /// 问卷/试卷快照id信息，供系统检索快照内容
        /// </summary>
        [JsonProperty("id")]
        public long Id { get; set; }
    }
}
