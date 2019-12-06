using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// SettleInfo Data Structure.
    /// </summary>
    public class SettleInfo : AlipayObject
    {
        /// <summary>
        /// 结算详细信息，json数组，目前只支持一条。
        /// </summary>
        [JsonPropertyName("settle_detail_infos")]
        public List<SettleDetailInfo> SettleDetailInfos { get; set; }
    }
}
