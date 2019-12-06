using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayEcoLogisticsExpressNonserviceQueryModel Data Structure.
    /// </summary>
    public class AlipayEcoLogisticsExpressNonserviceQueryModel : AlipayObject
    {
        /// <summary>
        /// 物流机构编码，参照物流机构编码文档，<a href="https://expressprod.oss-cn-hangzhou.aliyuncs.com/docs/%E5%AF%84%E4%BB%B6%E5%B9%B3%E5%8F%B0-%E7%89%A9%E6%B5%81%E6%9C%BA%E6%9E%84%E7%BC%96%E7%A0%81%E6%96%87%E6%A1%A3.xlsx">点此下载</a>。
        /// </summary>
        [JsonPropertyName("logis_merch_code")]
        public string LogisMerchCode { get; set; }
    }
}
