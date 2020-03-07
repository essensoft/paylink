using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayCommerceIotSupplierAssetBatchqueryModel Data Structure.
    /// </summary>
    public class AlipayCommerceIotSupplierAssetBatchqueryModel : AlipayObject
    {
        /// <summary>
        /// 当前页码
        /// </summary>
        [JsonPropertyName("cur_page_num")]
        public long CurPageNum { get; set; }

        /// <summary>
        /// 搜索关键字，设备型号、设备名称等
        /// </summary>
        [JsonPropertyName("keyword")]
        public string Keyword { get; set; }

        /// <summary>
        /// 查询分页大小
        /// </summary>
        [JsonPropertyName("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 供应商pid
        /// </summary>
        [JsonPropertyName("supplier_pid")]
        public string SupplierPid { get; set; }
    }
}
