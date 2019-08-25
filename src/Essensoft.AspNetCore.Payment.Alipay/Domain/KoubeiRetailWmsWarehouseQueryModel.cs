using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KoubeiRetailWmsWarehouseQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiRetailWmsWarehouseQueryModel : AlipayObject
    {
        /// <summary>
        /// 城市编码，国标码，与归属人ID查询配合使用
        /// </summary>
        [JsonProperty("city_code")]
        public string CityCode { get; set; }

        /// <summary>
        /// 操作上下文
        /// </summary>
        [JsonProperty("operate_context")]
        public OperateContext OperateContext { get; set; }

        /// <summary>
        /// 仓库的归属人类型，SUPPLIER供货商的仓库/PARTNER商户的仓库
        /// </summary>
        [JsonProperty("own_type")]
        public string OwnType { get; set; }

        /// <summary>
        /// 仓库的归属人ID、与仓库ID选择一个作为查询条件
        /// </summary>
        [JsonProperty("owner_id")]
        public string OwnerId { get; set; }

        /// <summary>
        /// 页码，分页参数，与归属人ID查询配合使用
        /// </summary>
        [JsonProperty("page_no")]
        public long PageNo { get; set; }

        /// <summary>
        /// 每页大小，分页参数，与归属人ID查询配合使用
        /// </summary>
        [JsonProperty("page_size")]
        public long PageSize { get; set; }

        /// <summary>
        /// 仓库编码、与归属人ID选择一个作为查询条件
        /// </summary>
        [JsonProperty("warehouse_code")]
        public string WarehouseCode { get; set; }
    }
}
