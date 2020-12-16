using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// LogisticsCompanyIstd Data Structure.
    /// </summary>
    public class LogisticsCompanyIstd : AlipayObject
    {
        /// <summary>
        /// 即时配送公司编码，由支付宝分配
        /// </summary>
        [JsonPropertyName("logistics_code")]
        public string LogisticsCode { get; set; }

        /// <summary>
        /// 即时配送公司服务代码列表
        /// </summary>
        [JsonPropertyName("service_codes")]
        public List<ServiceCodeIstd> ServiceCodes { get; set; }
    }
}
