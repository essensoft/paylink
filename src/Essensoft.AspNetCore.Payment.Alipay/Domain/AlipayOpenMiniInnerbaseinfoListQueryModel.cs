using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayOpenMiniInnerbaseinfoListQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayOpenMiniInnerbaseinfoListQueryModel : AlipayObject
    {
        /// <summary>
        /// 普通小程序/插件/模板
        /// </summary>
        [JsonProperty("app_sub_type")]
        public string AppSubType { get; set; }

        /// <summary>
        /// 开发者ID
        /// </summary>
        [JsonProperty("developer_id")]
        public string DeveloperId { get; set; }

        /// <summary>
        /// 租户编码
        /// </summary>
        [JsonProperty("inst_code")]
        public string InstCode { get; set; }

        /// <summary>
        /// 页数-0开始
        /// </summary>
        [JsonProperty("page_num")]
        public long PageNum { get; set; }

        /// <summary>
        /// 每页个数
        /// </summary>
        [JsonProperty("page_size")]
        public long PageSize { get; set; }
    }
}
