using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KoubeiCateringPosDeskCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiCateringPosDeskCreateModel : AlipayObject
    {
        /// <summary>
        /// 餐区ID
        /// </summary>
        [JsonProperty("area_id")]
        public string AreaId { get; set; }

        /// <summary>
        /// 桌位名称前缀
        /// </summary>
        [JsonProperty("desk_name")]
        public string DeskName { get; set; }

        /// <summary>
        /// 桌位最大可坐人数
        /// </summary>
        [JsonProperty("max_num")]
        public long MaxNum { get; set; }

        /// <summary>
        /// 批量添加桌位的数量
        /// </summary>
        [JsonProperty("num")]
        public long Num { get; set; }

        /// <summary>
        /// 门店ID
        /// </summary>
        [JsonProperty("shop_id")]
        public string ShopId { get; set; }
    }
}
