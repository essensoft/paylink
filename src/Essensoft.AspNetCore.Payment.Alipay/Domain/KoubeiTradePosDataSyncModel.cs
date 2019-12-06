using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KoubeiTradePosDataSyncModel Data Structure.
    /// </summary>
    public class KoubeiTradePosDataSyncModel : AlipayObject
    {
        /// <summary>
        /// 回流规则码，不同的规则码对应不同的回流规范，枚举如下  SYNC_001 对应餐饮业态点单产品回流规范  SYNC_002 对应零售业态售卖产品回流规范
        /// </summary>
        [JsonPropertyName("biz_code")]
        public string BizCode { get; set; }

        /// <summary>
        /// JSON格式，描述业务信息，根据回流规范文档传入。
        /// </summary>
        [JsonPropertyName("content")]
        public string Content { get; set; }
    }
}
