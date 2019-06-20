using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayCommerceTransportAdAduserqualificationBatchqueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceTransportAdAduserqualificationBatchqueryModel : AlipayObject
    {
        /// <summary>
        /// 广告主用户id + 根据广告主用户id查询对应的广告主资质列表
        /// </summary>
        [JsonProperty("ad_user_id")]
        public long AdUserId { get; set; }
    }
}
