using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// AlipayEcoCityserviceIndustrymsgAuthBatchqueryModel Data Structure.
    /// </summary>
    public class AlipayEcoCityserviceIndustrymsgAuthBatchqueryModel : AlipayObject
    {
        /// <summary>
        /// 用户身份信息列表，传入上限为100条
        /// </summary>
        [JsonPropertyName("certificate_info_list")]
        public List<CertificateInfo> CertificateInfoList { get; set; }

        /// <summary>
        /// 行业类型，目前可选： 1：社保 2：公积金 3：交管 4：公安非交管 5：医保
        /// </summary>
        [JsonPropertyName("industry_type")]
        public long IndustryType { get; set; }
    }
}
