using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// SceneExtParam Data Structure.
    /// </summary>
    public class SceneExtParam : AlipayObject
    {
        /// <summary>
        /// B流程申请准入原因
        /// </summary>
        [JsonPropertyName("apply_reason")]
        public string ApplyReason { get; set; }

        /// <summary>
        /// 机构的合约编号
        /// </summary>
        [JsonPropertyName("contract_no")]
        public string ContractNo { get; set; }

        /// <summary>
        /// 贴息金额，单位：分
        /// </summary>
        [JsonPropertyName("discountamt")]
        public string Discountamt { get; set; }

        /// <summary>
        /// 首付款，单位：分
        /// </summary>
        [JsonPropertyName("firstpayamt")]
        public string Firstpayamt { get; set; }

        /// <summary>
        /// 利率，xx%格式
        /// </summary>
        [JsonPropertyName("interestrate")]
        public string Interestrate { get; set; }

        /// <summary>
        /// 尾款，单位：分
        /// </summary>
        [JsonPropertyName("lastpayamt")]
        public string Lastpayamt { get; set; }

        /// <summary>
        /// 月供，单位：分，需要大于等于0
        /// </summary>
        [JsonPropertyName("monthpayamt")]
        public string Monthpayamt { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        [JsonPropertyName("remark")]
        public string Remark { get; set; }
    }
}
