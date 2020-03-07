using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// ShopServiceItem Data Structure.
    /// </summary>
    public class ShopServiceItem : AlipayObject
    {
        /// <summary>
        /// 对服务的项目的详细描述
        /// </summary>
        [JsonPropertyName("description")]
        public string Description { get; set; }

        /// <summary>
        /// 服务项目名称
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// 服务项目需要图片素材
        /// </summary>
        [JsonPropertyName("pictures")]
        public List<string> Pictures { get; set; }
    }
}
