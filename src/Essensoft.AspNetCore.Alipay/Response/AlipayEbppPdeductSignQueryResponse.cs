using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Alipay.Response
{
    /// <summary>
    /// AlipayEbppPdeductSignQueryResponse.
    /// </summary>
    public class AlipayEbppPdeductSignQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 协议ID
        /// </summary>
        [JsonProperty("agreement_id")]
        public string AgreementId { get; set; }

        /// <summary>
        /// 户号
        /// </summary>
        [JsonProperty("bill_key")]
        public string BillKey { get; set; }

        /// <summary>
        /// 出账机构
        /// </summary>
        [JsonProperty("charge_inst")]
        public string ChargeInst { get; set; }

        /// <summary>
        /// 朗新协议ID
        /// </summary>
        [JsonProperty("out_agreement_id")]
        public string OutAgreementId { get; set; }

        /// <summary>
        /// 签约时间
        /// </summary>
        [JsonProperty("sign_date")]
        public string SignDate { get; set; }

        /// <summary>
        /// 用户ID
        /// </summary>
        [JsonProperty("user_id")]
        public string UserId { get; set; }
    }
}
