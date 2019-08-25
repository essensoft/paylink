using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// ExproductconfResponse Data Structure.
    /// </summary>
    [Serializable]
    public class ExproductconfResponse : AlipayObject
    {
        /// <summary>
        /// 出账机构
        /// </summary>
        [JsonProperty("charge_inst")]
        public string ChargeInst { get; set; }

        /// <summary>
        /// 出账机构中文名称
        /// </summary>
        [JsonProperty("chargeinst_name")]
        public string ChargeinstName { get; set; }

        /// <summary>
        /// 销账机构
        /// </summary>
        [JsonProperty("chargeoff_inst")]
        public string ChargeoffInst { get; set; }

        /// <summary>
        /// 销账机构中文名称
        /// </summary>
        [JsonProperty("chargeoffinst_name")]
        public string ChargeoffinstName { get; set; }

        /// <summary>
        /// 城市
        /// </summary>
        [JsonProperty("city")]
        public string City { get; set; }

        /// <summary>
        /// 扩展字段
        /// </summary>
        [JsonProperty("extend")]
        public string Extend { get; set; }

        /// <summary>
        /// 省份
        /// </summary>
        [JsonProperty("province")]
        public string Province { get; set; }

        /// <summary>
        /// 产品状态
        /// </summary>
        [JsonProperty("status")]
        public string Status { get; set; }
    }
}
