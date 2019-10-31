using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// IsvLogisticsInfo Data Structure.
    /// </summary>
    [Serializable]
    public class IsvLogisticsInfo : AlipayObject
    {
        /// <summary>
        /// 快递公司
        /// </summary>
        [JsonProperty("express_company")]
        public string ExpressCompany { get; set; }

        /// <summary>
        /// 快递公司运单号
        /// </summary>
        [JsonProperty("express_company_bill_no")]
        public string ExpressCompanyBillNo { get; set; }
    }
}
