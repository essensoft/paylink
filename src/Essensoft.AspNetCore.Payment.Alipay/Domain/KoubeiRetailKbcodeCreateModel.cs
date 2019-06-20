using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KoubeiRetailKbcodeCreateModel Data Structure.
    /// </summary>
    [Serializable]
    public class KoubeiRetailKbcodeCreateModel : AlipayObject
    {
        /// <summary>
        /// 口碑码绑定的附加信息列表，最大数量150
        /// </summary>
        [JsonProperty("code_info_list")]
        public List<RetailKbcodeCreateVo> CodeInfoList { get; set; }

        /// <summary>
        /// 物料模板（口碑码的背景图，目前仅支持：RETAIL_PASTER_296_320）
        /// </summary>
        [JsonProperty("code_template")]
        public string CodeTemplate { get; set; }

        /// <summary>
        /// 生成码的类型（当前仅支持品牌商促销员码：KOUBEI_SALESMAN_CODEC）
        /// </summary>
        [JsonProperty("code_type")]
        public string CodeType { get; set; }

        /// <summary>
        /// 请求流水ID，可用于幂等控制，建议使用UUID做幂等控制
        /// </summary>
        [JsonProperty("request_id")]
        public string RequestId { get; set; }
    }
}
