using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// IsvLogisticsInfo Data Structure.
    /// </summary>
    public class IsvLogisticsInfo : AlipayObject
    {
        /// <summary>
        /// 快递公司
        /// </summary>
        [JsonPropertyName("express_company")]
        public string ExpressCompany { get; set; }

        /// <summary>
        /// 快递公司运单号
        /// </summary>
        [JsonPropertyName("express_company_bill_no")]
        public string ExpressCompanyBillNo { get; set; }
    }
}
