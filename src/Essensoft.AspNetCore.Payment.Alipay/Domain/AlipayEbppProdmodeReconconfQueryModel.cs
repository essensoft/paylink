using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayEbppProdmodeReconconfQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEbppProdmodeReconconfQueryModel : AlipayObject
    {
        /// <summary>
        /// 缴费业务类型
        /// </summary>
        [JsonProperty("biz_type")]
        public string BizType { get; set; }

        /// <summary>
        /// 销账机构编码
        /// </summary>
        [JsonProperty("chargeoff_code")]
        public string ChargeoffCode { get; set; }
    }
}
