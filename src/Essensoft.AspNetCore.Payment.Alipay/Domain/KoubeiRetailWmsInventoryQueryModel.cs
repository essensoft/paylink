using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KoubeiRetailWmsInventoryQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiRetailWmsInventoryQueryModel : AlipayObject
    {
        /// <summary>
        /// 批次号
        /// </summary>
        [JsonProperty("batch_code")]
        public string BatchCode { get; set; }

        /// <summary>
        /// 货品编码
        /// </summary>
        [JsonProperty("goods_code")]
        public string GoodsCode { get; set; }

        /// <summary>
        /// 货品类型，ZP("正品"),CC("残次"),JS("机损"), XS("箱损"),ZT("在途库存")
        /// </summary>
        [JsonProperty("inventory_type")]
        public string InventoryType { get; set; }

        /// <summary>
        /// 操作人信息
        /// </summary>
        [JsonProperty("operate_context")]
        public OperateContext OperateContext { get; set; }

        /// <summary>
        /// 页码（默认1，正整数）
        /// </summary>
        [JsonProperty("page_no")]
        public long PageNo { get; set; }

        /// <summary>
        /// 页面大小(最小为1，默认20，最大100)
        /// </summary>
        [JsonProperty("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 仓库编码
        /// </summary>
        [JsonProperty("warehouse_code")]
        public string WarehouseCode { get; set; }
    }
}
