using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayMarketingVoucherStockCreateModel Data Structure.
    /// </summary>
    public class AlipayMarketingVoucherStockCreateModel : AlipayObject
    {
        /// <summary>
        /// 券码列表，商户体系内可兑换使用的券码
        /// </summary>
        [JsonPropertyName("entity_list")]
        public List<string> EntityList { get; set; }

        /// <summary>
        /// 外部单据号, 请保持唯一, 如果重复则认为重复请求, 可以使用uuid生成或使用商户自己的单据号
        /// </summary>
        [JsonPropertyName("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 库存ID, 首次创建请填写空, 追加库存请填原始库存ID
        /// </summary>
        [JsonPropertyName("stock_id")]
        public string StockId { get; set; }
    }
}
