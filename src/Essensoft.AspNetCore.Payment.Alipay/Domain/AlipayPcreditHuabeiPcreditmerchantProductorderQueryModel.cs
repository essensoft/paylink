using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayPcreditHuabeiPcreditmerchantProductorderQueryModel Data Structure.
    /// </summary>
    public class AlipayPcreditHuabeiPcreditmerchantProductorderQueryModel : AlipayObject
    {
        /// <summary>
        /// 合约订购查询业务场景
        /// </summary>
        [JsonPropertyName("biz_from")]
        public string BizFrom { get; set; }

        /// <summary>
        /// 请求来源应用
        /// </summary>
        [JsonPropertyName("from_app")]
        public string FromApp { get; set; }

        /// <summary>
        /// 支付宝商户ID
        /// </summary>
        [JsonPropertyName("pid")]
        public string Pid { get; set; }

        /// <summary>
        /// 查询条件集合
        /// </summary>
        [JsonPropertyName("product_order_query_items")]
        public List<ProductOrderQueryItem> ProductOrderQueryItems { get; set; }
    }
}
