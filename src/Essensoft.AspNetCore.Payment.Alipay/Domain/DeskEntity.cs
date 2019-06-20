using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// DeskEntity Data Structure.
    /// </summary>
    [Serializable]
    public class DeskEntity : AlipayObject
    {
        /// <summary>
        /// 餐区ID
        /// </summary>
        [JsonProperty("area_id")]
        public string AreaId { get; set; }

        /// <summary>
        /// 餐桌名称
        /// </summary>
        [JsonProperty("desk_name")]
        public string DeskName { get; set; }

        /// <summary>
        /// 桌位编码
        /// </summary>
        [JsonProperty("desk_no")]
        public string DeskNo { get; set; }

        /// <summary>
        /// 桌台ID
        /// </summary>
        [JsonProperty("id")]
        public string Id { get; set; }

        /// <summary>
        /// 桌位人数
        /// </summary>
        [JsonProperty("max_num")]
        public long MaxNum { get; set; }

        /// <summary>
        /// 二维码id
        /// </summary>
        [JsonProperty("qr_code_id")]
        public string QrCodeId { get; set; }

        /// <summary>
        /// 餐桌二维码关系ID
        /// </summary>
        [JsonProperty("relation_id")]
        public string RelationId { get; set; }

        /// <summary>
        /// 门店ID
        /// </summary>
        [JsonProperty("shop_id")]
        public string ShopId { get; set; }

        /// <summary>
        /// 桌位排序
        /// </summary>
        [JsonProperty("sort_num")]
        public long SortNum { get; set; }
    }
}
