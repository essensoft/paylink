using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KoubeiRetailWmsSupplierQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiRetailWmsSupplierQueryModel : AlipayObject
    {
        /// <summary>
        /// 操作上下文
        /// </summary>
        [JsonProperty("operate_context")]
        public OperateContext OperateContext { get; set; }

        /// <summary>
        /// 供应商ID，限制批量查询100个ID
        /// </summary>
        [JsonProperty("supplier_ids")]
        public List<string> SupplierIds { get; set; }
    }
}
