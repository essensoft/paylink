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

        /// <summary>
        /// 该笔订单的超期自动确认结算时间，到达期限后，将自动确认结算。此字段只在签约账期结算模式时有效。取值范围：1d～365d。d-天。 该参数数值不接受小数点。
        /// </summary>
        [JsonPropertyName("settle_period_time")]
        public string SettlePeriodTime { get; set; }
    }
}
