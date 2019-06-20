using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayOpenPublicLifeLabelModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenPublicLifeLabelModifyModel : AlipayObject
    {
        /// <summary>
        /// 标签id，调用创建标签接口后由支付宝返回 ，只支持生活号自定义标签
        /// </summary>
        [JsonProperty("label_id")]
        public string LabelId { get; set; }

        /// <summary>
        /// 标签名
        /// </summary>
        [JsonProperty("label_name")]
        public string LabelName { get; set; }
    }
}
