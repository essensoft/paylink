using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// ZolozIdentificationCustomerEnrollCancelModel Data Structure.
    /// </summary>
    [Serializable]
    public class ZolozIdentificationCustomerEnrollCancelModel : AlipayObject
    {
        /// <summary>
        /// 商户请求的唯一标志，该标识作为对账的关键信息，商户要保证其唯一性
        /// </summary>
        [JsonProperty("biz_id")]
        public string BizId { get; set; }

        /// <summary>
        /// 商户的用户id
        /// </summary>
        [JsonProperty("user_id")]
        public string UserId { get; set; }
    }
}
