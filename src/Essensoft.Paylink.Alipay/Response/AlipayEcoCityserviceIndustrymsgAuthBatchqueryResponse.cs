using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.Paylink.Alipay.Domain;

namespace Essensoft.Paylink.Alipay.Response
{
    /// <summary>
    /// AlipayEcoCityserviceIndustrymsgAuthBatchqueryResponse.
    /// </summary>
    public class AlipayEcoCityserviceIndustrymsgAuthBatchqueryResponse : AlipayResponse
    {
        /// <summary>
        /// 筛选出来的在市民中心已订阅行业动帐消息的用户信息列表
        /// </summary>
        [JsonPropertyName("certificate_info_list")]
        public List<CertificateInfo> CertificateInfoList { get; set; }
    }
}
