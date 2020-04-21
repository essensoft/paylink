using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayOpenLotteryRegionModifyModel Data Structure.
    /// </summary>
    public class AlipayOpenLotteryRegionModifyModel : AlipayObject
    {
        /// <summary>
        /// 环境
        /// </summary>
        [JsonPropertyName("env")]
        public string Env { get; set; }
    }
}
