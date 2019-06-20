using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayUserAgreementExecutionplanModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayUserAgreementExecutionplanModifyModel : AlipayObject
    {
        /// <summary>
        /// 周期性扣款产品，授权免密支付协议号
        /// </summary>
        [JsonProperty("agreement_no")]
        public string AgreementNo { get; set; }

        /// <summary>
        /// 商户下一次扣款时间
        /// </summary>
        [JsonProperty("deduct_time")]
        public string DeductTime { get; set; }

        /// <summary>
        /// 具体修改原因
        /// </summary>
        [JsonProperty("memo")]
        public string Memo { get; set; }
    }
}
