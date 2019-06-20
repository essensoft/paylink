using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayUserElectronicidUserQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayUserElectronicidUserQueryModel : AlipayObject
    {
        /// <summary>
        /// 用户码码串
        /// </summary>
        [JsonProperty("barcode")]
        public string Barcode { get; set; }
    }
}
