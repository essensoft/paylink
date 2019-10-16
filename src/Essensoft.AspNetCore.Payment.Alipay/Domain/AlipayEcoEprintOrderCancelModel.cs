using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayEcoEprintOrderCancelModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEcoEprintOrderCancelModel : AlipayObject
    {
        /// <summary>
        /// 应用ID
        /// </summary>
        [JsonProperty("client_id")]
        public string ClientId { get; set; }

        /// <summary>
        /// 应用Secret
        /// </summary>
        [JsonProperty("client_secret")]
        public string ClientSecret { get; set; }

        /// <summary>
        /// 应用访问凭证
        /// </summary>
        [JsonProperty("eprint_token")]
        public string EprintToken { get; set; }

        /// <summary>
        /// 终端号
        /// </summary>
        [JsonProperty("machine_code")]
        public string MachineCode { get; set; }

        /// <summary>
        /// 待取消订单Id，云平台端订单Id
        /// </summary>
        [JsonProperty("order_id")]
        public string OrderId { get; set; }
    }
}
