using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// ArrangementConditionGroupSelector Data Structure.
    /// </summary>
    public class ArrangementConditionGroupSelector : AlipayObject
    {
        /// <summary>
        /// 是否选择最新的产品条件,默认为TRUE
        /// </summary>
        [JsonPropertyName("select_latest_pd_cd")]
        public bool SelectLatestPdCd { get; set; }
    }
}
