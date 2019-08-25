using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// OrderLogisticsInformation Data Structure.
    /// </summary>
    [Serializable]
    public class OrderLogisticsInformation : AlipayObject
    {
        /// <summary>
        /// 物流公司名称
        /// </summary>
        [JsonProperty("express_company")]
        public string ExpressCompany { get; set; }

        /// <summary>
        /// 物流单号
        /// </summary>
        [JsonProperty("tracking_no")]
        public string TrackingNo { get; set; }
    }
}
