using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Alipay.Domain
{
    /// <summary>
    /// MybankCreditCreditriskWidgetQueryModel Data Structure.
    /// </summary>
    public class MybankCreditCreditriskWidgetQueryModel : AlipayObject
    {
        /// <summary>
        /// 支付宝userid
        /// </summary>
        [JsonProperty("alipay_user_id")]
        public string AlipayUserId { get; set; }
    }
}
