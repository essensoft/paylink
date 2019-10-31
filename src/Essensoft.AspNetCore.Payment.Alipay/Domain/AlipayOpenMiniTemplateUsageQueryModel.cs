using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayOpenMiniTemplateUsageQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenMiniTemplateUsageQueryModel : AlipayObject
    {
        /// <summary>
        /// 端参数，可不选，默认支付宝端
        /// </summary>
        [JsonProperty("bundle_id")]
        public string BundleId { get; set; }

        /// <summary>
        /// 查询的页数，默认第一页
        /// </summary>
        [JsonProperty("page_num")]
        public long PageNum { get; set; }

        /// <summary>
        /// 每页的数量，最多查询50个，默认查询10个
        /// </summary>
        [JsonProperty("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 模板id
        /// </summary>
        [JsonProperty("template_id")]
        public string TemplateId { get; set; }

        /// <summary>
        /// 模板小程序的版本号
        /// </summary>
        [JsonProperty("template_version")]
        public string TemplateVersion { get; set; }
    }
}
