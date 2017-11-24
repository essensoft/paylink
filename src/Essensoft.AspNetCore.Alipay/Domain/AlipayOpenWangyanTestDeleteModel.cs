using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Alipay.Domain
{
    /// <summary>
    /// AlipayOpenWangyanTestDeleteModel Data Structure.
    /// </summary>
    public class AlipayOpenWangyanTestDeleteModel : AlipayObject
    {
        /// <summary>
        /// 1
        /// </summary>
        [JsonProperty("aaa")]
        public string Aaa { get; set; }

        /// <summary>
        /// 2
        /// </summary>
        [JsonProperty("user_name")]
        public string UserName { get; set; }
    }
}
