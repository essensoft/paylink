using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// ZhimaMerchantActivityParticipationQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class ZhimaMerchantActivityParticipationQueryModel : AlipayObject
    {
        /// <summary>
        /// 承诺消费合约号
        /// </summary>
        [JsonProperty("contract_no")]
        public string ContractNo { get; set; }
    }
}
