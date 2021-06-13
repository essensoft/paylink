using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// AlipayAssetPointVoucherprodBenefittemplateOfflineResponse.
    /// </summary>
    public class AlipayAssetPointVoucherprodBenefittemplateOfflineResponse : AlipayResponse
    {
        /// <summary>
        /// 快速下线，true表示模版已过期并且已经退回资金，false表示模版已过期，但是尚未退回资金
        /// </summary>
        [JsonPropertyName("quick_recycle")]
        public bool QuickRecycle { get; set; }
    }
}
