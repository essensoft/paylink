using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// MybankCreditCreditriskGuarschemeQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class MybankCreditCreditriskGuarschemeQueryModel : AlipayObject
    {
        /// <summary>
        /// 担保方案查询类型，TYZBL：通用自保理业务场景
        /// </summary>
        [JsonProperty("bsn_type")]
        public string BsnType { get; set; }

        /// <summary>
        /// 销售产品码，特殊可选，某些场景是必填的
        /// </summary>
        [JsonProperty("sale_pd_code")]
        public string SalePdCode { get; set; }

        /// <summary>
        /// 用户身份信息
        /// </summary>
        [JsonProperty("user")]
        public Member User { get; set; }
    }
}
