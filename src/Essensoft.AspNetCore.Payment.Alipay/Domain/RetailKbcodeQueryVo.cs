using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// RetailKbcodeQueryVo Data Structure.
    /// </summary>
    [Serializable]
    public class RetailKbcodeQueryVo : AlipayObject
    {
        /// <summary>
        /// 创建口碑码的批次号
        /// </summary>
        [JsonProperty("batch_id")]
        public string BatchId { get; set; }

        /// <summary>
        /// 码的物料模板
        /// </summary>
        [JsonProperty("code_template")]
        public string CodeTemplate { get; set; }

        /// <summary>
        /// 商户名称，生成码的时候码图片上的提示文案
        /// </summary>
        [JsonProperty("code_tip")]
        public string CodeTip { get; set; }

        /// <summary>
        /// 口碑码(不带背景)
        /// </summary>
        [JsonProperty("code_url")]
        public string CodeUrl { get; set; }

        /// <summary>
        /// 口碑码创建时间
        /// </summary>
        [JsonProperty("create_time")]
        public string CreateTime { get; set; }

        /// <summary>
        /// 口碑码id
        /// </summary>
        [JsonProperty("qr_code")]
        public string QrCode { get; set; }

        /// <summary>
        /// 口碑码（带背景）
        /// </summary>
        [JsonProperty("resource_url")]
        public string ResourceUrl { get; set; }

        /// <summary>
        /// 促销员信息
        /// </summary>
        [JsonProperty("salesman")]
        public string Salesman { get; set; }
    }
}
