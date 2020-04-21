using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayCommerceTransportAdAduserqualificationBatchqueryResponse.
    /// </summary>
    public class AlipayCommerceTransportAdAduserqualificationBatchqueryResponse : AlipayResponse
    {
        /// <summary>
        /// 广告主用户资质列表 + 根据广告主用户id获得对应的资质列表
        /// </summary>
        [JsonPropertyName("ad_user_qualification")]
        public List<AdUserQualification> AdUserQualification { get; set; }
    }
}
