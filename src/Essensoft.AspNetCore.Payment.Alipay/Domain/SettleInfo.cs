using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// SettleInfo Data Structure.
    /// </summary>
    [Serializable]
    public class SettleInfo : AlipayObject
    {
        /// <summary>
        /// 结算详细信息，json数组，目前只支持一条。
        /// </summary>
        [JsonProperty("settle_detail_infos")]
        public List<SettleDetailInfo> SettleDetailInfos { get; set; }
    }
}
