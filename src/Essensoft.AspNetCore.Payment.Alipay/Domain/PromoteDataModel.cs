using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// PromoteDataModel Data Structure.
    /// </summary>
    [Serializable]
    public class PromoteDataModel : AlipayObject
    {
        /// <summary>
        /// 核销数
        /// </summary>
        [JsonProperty("checked_voucher_num")]
        [XmlElement("checked_voucher_num")]
        public long CheckedVoucherNum { get; set; }

        /// <summary>
        /// 领券数
        /// </summary>
        [JsonProperty("claim_voucher_num")]
        [XmlElement("claim_voucher_num")]
        public long ClaimVoucherNum { get; set; }

        /// <summary>
        /// 分佣金额
        /// </summary>
        [JsonProperty("commission_amount")]
        [XmlElement("commission_amount")]
        public string CommissionAmount { get; set; }
    }
}
