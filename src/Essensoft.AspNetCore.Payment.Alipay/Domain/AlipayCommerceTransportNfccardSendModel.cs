using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayCommerceTransportNfccardSendModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceTransportNfccardSendModel : AlipayObject
    {
        /// <summary>
        /// 卡号
        /// </summary>
        [JsonProperty("card_no")]
        public string CardNo { get; set; }

        /// <summary>
        /// 卡片状态（FREEZE：冻结，CANCEL：销卡）
        /// </summary>
        [JsonProperty("card_status")]
        public string CardStatus { get; set; }

        /// <summary>
        /// 发卡机构代码
        /// </summary>
        [JsonProperty("issue_org_no")]
        public string IssueOrgNo { get; set; }
    }
}
