using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// SceneExtParam Data Structure.
    /// </summary>
    [Serializable]
    public class SceneExtParam : AlipayObject
    {
        /// <summary>
        /// B流程申请准入原因
        /// </summary>
        [JsonProperty("apply_reason")]
        public string ApplyReason { get; set; }

        /// <summary>
        /// 机构的合约编号
        /// </summary>
        [JsonProperty("contract_no")]
        public string ContractNo { get; set; }

        /// <summary>
        /// 贴息金额，单位：分
        /// </summary>
        [JsonProperty("discountamt")]
        public string Discountamt { get; set; }

        /// <summary>
        /// 首付款，单位：分
        /// </summary>
        [JsonProperty("firstpayamt")]
        public string Firstpayamt { get; set; }

        /// <summary>
        /// 利率，xx%格式
        /// </summary>
        [JsonProperty("interestrate")]
        public string Interestrate { get; set; }

        /// <summary>
        /// 尾款，单位：分
        /// </summary>
        [JsonProperty("lastpayamt")]
        public string Lastpayamt { get; set; }

        /// <summary>
        /// 月供，单位：分，需要大于等于0
        /// </summary>
        [JsonProperty("monthpayamt")]
        public string Monthpayamt { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        [JsonProperty("remark")]
        public string Remark { get; set; }
    }
}
