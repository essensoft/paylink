using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KoubeiCateringCookConditionBatchqueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiCateringCookConditionBatchqueryModel : AlipayObject
    {
        /// <summary>
        /// 商户的支付宝user_id. 商户授权后,isv能获得
        /// </summary>
        [JsonProperty("merchant_id")]
        public string MerchantId { get; set; }

        /// <summary>
        /// 查询页码，表示第几页
        /// </summary>
        [JsonProperty("page_no")]
        public string PageNo { get; set; }

        /// <summary>
        /// 分页大小，表示每页查询数量，不超过50
        /// </summary>
        [JsonProperty("page_size")]
        public string PageSize { get; set; }

        /// <summary>
        /// 口碑店铺id
        /// </summary>
        [JsonProperty("shop_id")]
        public string ShopId { get; set; }
    }
}
