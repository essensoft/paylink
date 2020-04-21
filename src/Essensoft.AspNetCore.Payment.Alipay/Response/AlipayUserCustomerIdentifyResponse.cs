using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayUserCustomerIdentifyResponse.
    /// </summary>
    public class AlipayUserCustomerIdentifyResponse : AlipayResponse
    {
        /// <summary>
        /// 账户互通活动信息列表，目前支持的活动名称  PAYMENT_NEW_CUSTOMER, 支付拉新
        /// </summary>
        [JsonPropertyName("activity_list")]
        public List<AlipayUserCustIdentifyActivity> ActivityList { get; set; }

        /// <summary>
        /// 用户画像信息，预留参数。返回用户画像信息，例如用户特征或者其他脱敏后的信息。
        /// </summary>
        [JsonPropertyName("user_profile")]
        public string UserProfile { get; set; }
    }
}
