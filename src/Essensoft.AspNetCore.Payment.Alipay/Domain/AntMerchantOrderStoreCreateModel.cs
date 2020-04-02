using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AntMerchantOrderStoreCreateModel Data Structure.
    /// </summary>
    public class AntMerchantOrderStoreCreateModel : AlipayObject
    {
        /// <summary>
        /// 买家id
        /// </summary>
        [JsonPropertyName("buyer_id")]
        public string BuyerId { get; set; }

        /// <summary>
        /// 联系电话
        /// </summary>
        [JsonPropertyName("contact_phone")]
        public string ContactPhone { get; set; }

        /// <summary>
        /// 扩展参数: CONSUMER_COUNT ：到店人数, 样例：3 SERVICE_ITEM：服务项目，样例: ["洗头","美发"] SERVICE_TIME: 到店时间，样例: 2020-03-10 09:00:00
        /// </summary>
        [JsonPropertyName("ext")]
        public List<OrderExt> Ext { get; set; }

        /// <summary>
        /// 订单相关的商品信息
        /// </summary>
        [JsonPropertyName("goods_info_list")]
        public List<StoreOrderGood> GoodsInfoList { get; set; }

        /// <summary>
        /// 订单超时时间，默认60分钟
        /// </summary>
        [JsonPropertyName("invalid_time")]
        public long InvalidTime { get; set; }

        /// <summary>
        /// 订单的描述
        /// </summary>
        [JsonPropertyName("memo")]
        public string Memo { get; set; }

        /// <summary>
        /// 外部业务号
        /// </summary>
        [JsonPropertyName("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 插件业务场景code，预约为ShopService
        /// </summary>
        [JsonPropertyName("scene")]
        public string Scene { get; set; }

        /// <summary>
        /// 卖家id
        /// </summary>
        [JsonPropertyName("seller_id")]
        public string SellerId { get; set; }

        /// <summary>
        /// 线下门店ID
        /// </summary>
        [JsonPropertyName("shop_id")]
        public string ShopId { get; set; }

        /// <summary>
        /// 线上店的ID
        /// </summary>
        [JsonPropertyName("store_open_id")]
        public string StoreOpenId { get; set; }

        /// <summary>
        /// 姓名
        /// </summary>
        [JsonPropertyName("user_name")]
        public string UserName { get; set; }
    }
}
