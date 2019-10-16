using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KoubeiQualityTestShieldOrderCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiQualityTestShieldOrderCreateModel : AlipayObject
    {
        /// <summary>
        /// 枚举类型 ADD_DISH: C端加菜 DELETE_DISH: C端减菜
        /// </summary>
        [JsonProperty("action_name")]
        public string ActionName { get; set; }

        /// <summary>
        /// 加购单号
        /// </summary>
        [JsonProperty("batch_no")]
        public string BatchNo { get; set; }

        /// <summary>
        /// 菜谱id
        /// </summary>
        [JsonProperty("cook_id")]
        public string CookId { get; set; }

        /// <summary>
        /// 菜品信息
        /// </summary>
        [JsonProperty("dish_list")]
        public List<ShieldDishList> DishList { get; set; }

        /// <summary>
        /// 扩展信息
        /// </summary>
        [JsonProperty("ext_infos")]
        public string ExtInfos { get; set; }

        /// <summary>
        /// 口碑订单号 第一次加购时不填，在后付订单上继续加购时需要传入
        /// </summary>
        [JsonProperty("order_id")]
        public string OrderId { get; set; }

        /// <summary>
        /// 外部业务号
        /// </summary>
        [JsonProperty("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 商户ID
        /// </summary>
        [JsonProperty("partner_id")]
        public string PartnerId { get; set; }

        /// <summary>
        /// 点餐类型 ADVANCE_PAYMENT：先付； AFTER_PAYMENT：后付；
        /// </summary>
        [JsonProperty("pay_style")]
        public string PayStyle { get; set; }

        /// <summary>
        /// 口碑门店ID
        /// </summary>
        [JsonProperty("shop_id")]
        public string ShopId { get; set; }

        /// <summary>
        /// 桌码，扫桌码订单必传
        /// </summary>
        [JsonProperty("table_no")]
        public string TableNo { get; set; }
    }
}
