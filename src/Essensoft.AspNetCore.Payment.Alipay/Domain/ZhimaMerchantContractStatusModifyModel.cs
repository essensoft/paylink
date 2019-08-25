using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// ZhimaMerchantContractStatusModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class ZhimaMerchantContractStatusModifyModel : AlipayObject
    {
        /// <summary>
        /// 合约状态变更操作发生的时间
        /// </summary>
        [JsonProperty("action_time")]
        public string ActionTime { get; set; }

        /// <summary>
        /// 合约状态操作类型必须为以下列表的一种  ACTIVE表示激活合约，前置合约状态INIT  INVALID表示作废合约，前置合约状态为INIT
        /// </summary>
        [JsonProperty("action_type")]
        public string ActionType { get; set; }

        /// <summary>
        /// 承诺消费合约号，唯一定位用户的一笔合约
        /// </summary>
        [JsonProperty("contract_no")]
        public string ContractNo { get; set; }
    }
}
