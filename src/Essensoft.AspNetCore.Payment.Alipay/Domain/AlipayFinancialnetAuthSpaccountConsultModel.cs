using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayFinancialnetAuthSpaccountConsultModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayFinancialnetAuthSpaccountConsultModel : AlipayObject
    {
        /// <summary>
        /// 业务标识ID
        /// </summary>
        [JsonProperty("biz_identity")]
        public string BizIdentity { get; set; }

        /// <summary>
        /// 签约产品ID
        /// </summary>
        [JsonProperty("sign_product_id")]
        public string SignProductId { get; set; }

        /// <summary>
        /// 蚂蚁统一会员ID
        /// </summary>
        [JsonProperty("user_id")]
        public string UserId { get; set; }
    }
}
