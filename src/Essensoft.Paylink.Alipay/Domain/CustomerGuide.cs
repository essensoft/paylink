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
        /// 卡包详情页可跳转的小程序appId。 限制： 该appId归属的pid必须和当前商户保持一致。 目前mini_app_id与store_ids必须二选一。
        /// </summary>
        [JsonPropertyName("mini_app_id")]
        public string MiniAppId { get; set; }

        /// <summary>
        /// 指定跳转到mini_app_id时的具体页面路径。 限制： 该小程序路径是相对路径。
        /// </summary>
        [JsonPropertyName("mini_app_path")]
        public string MiniAppPath { get; set; }

        /// <summary>
        /// 券可使用的门店列表。 接口参数是列表类型。  限制： store_ids中的门店id必须是支付宝门店id。  store_ids如果包含重复的门店id会自动进行去重操作。  传入的store_ids中包含的门店id数量 <= 3000。  修改门店列表，只允许增加不允许减少。
        /// </summary>
        [JsonPropertyName("store_ids")]
        public List<string> StoreIds { get; set; }
    }
}
