using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// SpecEntity Data Structure.
    /// </summary>
    [Serializable]
    public class SpecEntity : AlipayObject
    {
        /// <summary>
        /// 新增不用传，修改必须传
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; }

        /// <summary>
        /// 门店ID
        /// </summary>
        [JsonProperty("shop_id")]
        public string ShopId { get; set; }

        /// <summary>
        /// 规格名称
        /// </summary>
        [JsonProperty("spec_name")]
        public string SpecName { get; set; }

        /// <summary>
        /// 是否为系统默认规格,同步时，默认为false，设置不生效，只有查询现实时用
        /// </summary>
        [JsonProperty("system")]
        public bool System { get; set; }
    }
}
