using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Alipay.Domain
{
    /// <summary>
    /// KoubeiRetailTopinstanceQueryModel Data Structure.
    /// </summary>
    public class KoubeiRetailTopinstanceQueryModel : AlipayObject
    {
        /// <summary>
        /// 券或者电子DM单（VOUCHER、DM）
        /// </summary>
        [JsonProperty("instance_type")]
        public string InstanceType { get; set; }
    }
}
