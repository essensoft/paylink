using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.LianLianPay.Domain
{
    /// <summary>
    /// 支行信息
    /// </summary>
    public class Brabank
    {
        /// <summary>
        /// 大额行号
        /// </summary>
        [JsonProperty("prcptcd")]
        public string Prcptcd { get; set; }

        /// <summary>
        /// 开户支行名称全称
        /// </summary>
        [JsonProperty("brabank_name")]
        public string BrabankName { get; set; }
    }
}
