using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayEbppJfexportInputfieldQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayEbppJfexportInputfieldQueryModel : AlipayObject
    {
        /// <summary>
        /// 业务类型，固定传JF，表示缴费
        /// </summary>
        [JsonProperty("biz_type")]
        public string BizType { get; set; }

        /// <summary>
        /// 出账机构英文简称
        /// </summary>
        [JsonProperty("charge_inst")]
        public string ChargeInst { get; set; }

        /// <summary>
        /// 拓展字段
        /// </summary>
        [JsonProperty("extend_field")]
        public string ExtendField { get; set; }

        /// <summary>
        /// 获取场景:load，加载展示，渲染初始页面时的场景，例如户号的输入规则；query，查询展示，查询成功后确认页面的场景，例如缴费金额的输入规则；all，返回包含load和query两中场景。
        /// </summary>
        [JsonProperty("field_scene")]
        public string FieldScene { get; set; }

        /// <summary>
        /// 子业务类型：ELECTRIC-电费，WATER-水费，GAS-燃气费
        /// </summary>
        [JsonProperty("sub_biz_type")]
        public string SubBizType { get; set; }
    }
}
