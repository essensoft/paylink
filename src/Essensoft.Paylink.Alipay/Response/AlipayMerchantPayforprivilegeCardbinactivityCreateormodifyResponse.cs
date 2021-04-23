using System.Text.Json.Serialization;
using Essensoft.Paylink.Alipay.Domain;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// AlipayMerchantPayforprivilegeCardbinactivityCreateormodifyResponse.
    /// </summary>
    public class AlipayMerchantPayforprivilegeCardbinactivityCreateormodifyResponse : AlipayResponse
    {
        /// <summary>
        /// 新增/修改的结果
        /// </summary>
        [JsonPropertyName("card_bin_info")]
        public CardBinActivityInfo CardBinInfo { get; set; }
    }
}
