using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// ItermInfo Data Structure.
    /// </summary>
    [Serializable]
    public class ItermInfo : AlipayObject
    {
        /// <summary>
        /// 更新时系统异常，返回错误详细信息
        /// </summary>
        [JsonProperty("error_message")]
        public string ErrorMessage { get; set; }

        /// <summary>
        /// 充值面额的状态Y/N
        /// </summary>
        [JsonProperty("is_for_sale")]
        public string IsForSale { get; set; }

        /// <summary>
        /// 面额的code，唯一标示码
        /// </summary>
        [JsonProperty("item_code")]
        public string ItemCode { get; set; }

        /// <summary>
        /// 售价，比如100的面额，卖99元
        /// </summary>
        [JsonProperty("mark_price")]
        public string MarkPrice { get; set; }

        /// <summary>
        /// 针对更新时，是否更新成功
        /// </summary>
        [JsonProperty("success")]
        public bool Success { get; set; }

        /// <summary>
        /// 手机充值的面额价格
        /// </summary>
        [JsonProperty("supplier_price")]
        public string SupplierPrice { get; set; }
    }
}
