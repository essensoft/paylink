using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayOpenAppSmsgDataSyncModel Data Structure.
    /// </summary>
    public class AlipayOpenAppSmsgDataSyncModel : AlipayObject
    {
        /// <summary>
        /// 10
        /// </summary>
        [JsonPropertyName("data_one")]
        public string DataOne { get; set; }

        /// <summary>
        /// abc
        /// </summary>
        [JsonPropertyName("data_two")]
        public string DataTwo { get; set; }
    }
}
