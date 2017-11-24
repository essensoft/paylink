using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Alipay.Domain
{
    /// <summary>
    /// CraftsmanWorkOutIdOpenModel Data Structure.
    /// </summary>
    public class CraftsmanWorkOutIdOpenModel : AlipayObject
    {
        /// <summary>
        /// 外部作品id，isv生成，isv的appId+out_work_id全局唯一
        /// </summary>
        [JsonProperty("out_work_id")]
        public string OutWorkId { get; set; }

        /// <summary>
        /// 支付宝生成的作品id，全局唯一，用于修改删除作品
        /// </summary>
        [JsonProperty("work_id")]
        public string WorkId { get; set; }
    }
}
