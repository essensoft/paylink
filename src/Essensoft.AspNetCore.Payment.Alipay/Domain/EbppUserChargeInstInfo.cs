using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// EbppUserChargeInstInfo Data Structure.
    /// </summary>
    [Serializable]
    public class EbppUserChargeInstInfo : AlipayObject
    {
        /// <summary>
        /// 业务类型缩写:  JF-缴费
        /// </summary>
        [JsonProperty("biz_type")]
        public string BizType { get; set; }

        /// <summary>
        /// 出账机构缩写
        /// </summary>
        [JsonProperty("charge_inst")]
        public string ChargeInst { get; set; }

        /// <summary>
        /// 出账机构全称
        /// </summary>
        [JsonProperty("charge_inst_name")]
        public string ChargeInstName { get; set; }

        /// <summary>
        /// 子业务类型英文名称:  ELECTRIC-电力  GAS-燃气  WATER-水
        /// </summary>
        [JsonProperty("sub_biz_type")]
        public string SubBizType { get; set; }
    }
}
