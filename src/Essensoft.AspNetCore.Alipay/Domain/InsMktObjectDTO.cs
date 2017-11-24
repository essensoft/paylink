using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Alipay.Domain
{
    /// <summary>
    /// InsMktObjectDTO Data Structure.
    /// </summary>
    public class InsMktObjectDTO : AlipayObject
    {
        /// <summary>
        /// 活动标的id
        /// </summary>
        [JsonProperty("obj_id")]
        public string ObjId { get; set; }

        /// <summary>
        /// 标的类型
        /// </summary>
        [JsonProperty("type")]
        public long Type { get; set; }
    }
}
