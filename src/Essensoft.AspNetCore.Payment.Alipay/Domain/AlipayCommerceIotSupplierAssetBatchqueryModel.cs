using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayCommerceIotSupplierAssetBatchqueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayCommerceIotSupplierAssetBatchqueryModel : AlipayObject
    {
        /// <summary>
        /// 当前页码
        /// </summary>
        [JsonProperty("cur_page_num")]
        public long CurPageNum { get; set; }

        /// <summary>
        /// 搜索关键字，设备型号、设备名称等
        /// </summary>
        [JsonProperty("keyword")]
        public string Keyword { get; set; }

        /// <summary>
        /// 查询分页大小
        /// </summary>
        [JsonProperty("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 供应商pid
        /// </summary>
        [JsonProperty("supplier_pid")]
        public string SupplierPid { get; set; }
    }
}
