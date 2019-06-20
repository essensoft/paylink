using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipaySocialBaseGroupCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipaySocialBaseGroupCreateModel : AlipayObject
    {
        /// <summary>
        /// 业务方传入的唯一id，做为幂等使用
        /// </summary>
        [JsonProperty("biz_no")]
        public string BizNo { get; set; }

        /// <summary>
        /// 群的业务类型，目前只能为0
        /// </summary>
        [JsonProperty("biz_type")]
        public string BizType { get; set; }

        /// <summary>
        /// 建群时初始化的群设置
        /// </summary>
        [JsonProperty("group_settings")]
        public GroupSetting GroupSettings { get; set; }

        /// <summary>
        /// 建群的时候，群主的userid
        /// </summary>
        [JsonProperty("master_id")]
        public string MasterId { get; set; }
    }
}
