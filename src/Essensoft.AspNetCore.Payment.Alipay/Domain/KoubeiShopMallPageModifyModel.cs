using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KoubeiShopMallPageModifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiShopMallPageModifyModel : AlipayObject
    {
        /// <summary>
        /// 商圈id
        /// </summary>
        [JsonProperty("mall_id")]
        public string MallId { get; set; }

        /// <summary>
        /// 商圈访问地址
        /// </summary>
        [JsonProperty("mall_url")]
        public string MallUrl { get; set; }

        /// <summary>
        /// 废弃！，务传。
        /// </summary>
        [JsonProperty("out_biz_id")]
        public string OutBizId { get; set; }
    }
}
