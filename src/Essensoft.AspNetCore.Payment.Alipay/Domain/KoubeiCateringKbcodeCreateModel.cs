using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KoubeiCateringKbcodeCreateModel Data Structure.
    /// </summary>
    public class KoubeiCateringKbcodeCreateModel : AlipayObject
    {
        /// <summary>
        /// 口碑码绑定的门店或者桌号信息列表
        /// </summary>
        [JsonPropertyName("bind_info_list")]
        public List<KbCodeBindInfoVO> BindInfoList { get; set; }

        /// <summary>
        /// 请求流水ID，用于幂等控制
        /// </summary>
        [JsonPropertyName("request_id")]
        public string RequestId { get; set; }

        /// <summary>
        /// 物料模板（可以不填，系统会根据码类型默认一个模板）
        /// </summary>
        [JsonPropertyName("stuff_template")]
        public string StuffTemplate { get; set; }

        /// <summary>
        /// 生成码的类型（桌码：TABLE_PASTER，门店码：DOOR_PASTER）
        /// </summary>
        [JsonPropertyName("stuff_type")]
        public string StuffType { get; set; }
    }
}
