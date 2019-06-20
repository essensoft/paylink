using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// MybankCreditGuaranteeContractSignModel Data Structure.
    /// </summary>
    [Serializable]
    public class MybankCreditGuaranteeContractSignModel : AlipayObject
    {
        /// <summary>
        /// 支付宝ID
        /// </summary>
        [JsonProperty("alipay_id")]
        public string AlipayId { get; set; }

        /// <summary>
        /// Havana ID
        /// </summary>
        [JsonProperty("havana_id")]
        public string HavanaId { get; set; }

        /// <summary>
        /// 会员站点：AE:速卖通，ALIPAY:支付宝，MYBANK:网商银行，TAOBAO：淘宝，B2B_CN：中文站，B2B_EN：国际站
        /// </summary>
        [JsonProperty("site")]
        public string Site { get; set; }

        /// <summary>
        /// 会员站点ID
        /// </summary>
        [JsonProperty("site_user_id")]
        public string SiteUserId { get; set; }
    }
}
