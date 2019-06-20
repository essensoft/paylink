using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayEcoEduKtDownloadurlQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEcoEduKtDownloadurlQueryModel : AlipayObject
    {
        /// <summary>
        /// 账单时间：日账单格式为yyyy-MM-dd
        /// </summary>
        [JsonProperty("bill_date")]
        public string BillDate { get; set; }

        /// <summary>
        /// ISV的支付宝唯一标识PID
        /// </summary>
        [JsonProperty("partner_pid")]
        public string PartnerPid { get; set; }
    }
}
