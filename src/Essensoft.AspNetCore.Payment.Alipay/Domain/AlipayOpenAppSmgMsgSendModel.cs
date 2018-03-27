using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayOpenAppSmgMsgSendModel Data Structure.
    /// </summary>
    public class AlipayOpenAppSmgMsgSendModel : AlipayObject
    {
        /// <summary>
        /// 5555
        /// </summary>
        [JsonProperty("numberone")]
        public string Numberone { get; set; }

        /// <summary>
        /// 22
        /// </summary>
        [JsonProperty("numbertowe")]
        public string Numbertowe { get; set; }
    }
}
