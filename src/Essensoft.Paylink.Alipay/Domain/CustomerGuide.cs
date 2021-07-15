using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.Paylink.Alipay.Domain
{
    /// <summary>
    /// CustomerGuide Data Structure.
    /// </summary>
    public class CustomerGuide : AlipayObject
    {
        /// <summary>
        /// 卡包详情页可跳转的小程序appId。 限制： 该appId归属的pid必须和当前商户保持一致。 目前mini_app_id、store_ids、real_shop_ids必须三选一。
        /// </summary>
        [JsonPropertyName("mini_app_id")]
        public string MiniAppId { get; set; }

        /// <summary>
        /// 指定跳转到mini_app_id时的具体页面路径。 限制： 该小程序路径是相对路径。
        /// </summary>
        [JsonPropertyName("mini_app_path")]
        public string MiniAppPath { get; set; }

        /// <summary>
        /// 代运营商业关系门店列表，列表中的门店id是调用接口alipay.business.relation.shop.create创建门店返回的real_shop_id   接口参数是列表类型。  限制： real_shop_ids中的门店id必须是代运营商业关系门店id。  real_shop_ids如果包含重复的门店id会自动进行去重操作。  修改门店列表，只允许增加不允许减少。
        /// </summary>
        [JsonPropertyName("real_shop_ids")]
        public List<string> RealShopIds { get; set; }

        /// <summary>
        /// 券可使用的门店列表。列表中的门店id是通过调用接口ant.merchant.expand.shop.create创建门店返回的支付宝门店id   接口参数是列表类型。   限制： store_ids中的门店id必须是支付宝门店id。 store_ids如果包含重复的门店id会自动进行去重操作。   修改门店列表，只允许增加不允许减少。
        /// </summary>
        [JsonPropertyName("store_ids")]
        public List<string> StoreIds { get; set; }
    }
}
