using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KbdishEstimatedInfo Data Structure.
    /// </summary>
    [Serializable]
    public class KbdishEstimatedInfo : AlipayObject
    {
        /// <summary>
        /// 估清的菜品dishid或者materialId,该值对应的类型由dsType指定。
        /// </summary>
        [JsonProperty("ds_id")]
        public string DsId { get; set; }

        /// <summary>
        /// dishid:菜品维度估清  materialid:加料维度沽清
        /// </summary>
        [JsonProperty("ds_type")]
        public string DsType { get; set; }

        /// <summary>
        /// 估清后临时库存.大于等于0的数字。  status=open必须要传一个数。  在沽清类型为加料的时候，该项强制为0。
        /// </summary>
        [JsonProperty("inventory")]
        public string Inventory { get; set; }

        /// <summary>
        /// 口碑门店ID
        /// </summary>
        [JsonProperty("shop_id")]
        public string ShopId { get; set; }

        /// <summary>
        /// 状态。open:估清;stop:取消估清
        /// </summary>
        [JsonProperty("status")]
        public string Status { get; set; }

        /// <summary>
        /// 估清最后修改人
        /// </summary>
        [JsonProperty("update_user")]
        public string UpdateUser { get; set; }
    }
}
