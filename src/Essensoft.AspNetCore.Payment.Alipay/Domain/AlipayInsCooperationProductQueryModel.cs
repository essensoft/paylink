using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayInsCooperationProductQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayInsCooperationProductQueryModel : AlipayObject
    {
        /// <summary>
        /// 产品编码;由蚂蚁保险平台分配,商户通过该产品编码投保特定的保险产品
        /// </summary>
        [JsonProperty("prod_code")]
        public string ProdCode { get; set; }
    }
}
