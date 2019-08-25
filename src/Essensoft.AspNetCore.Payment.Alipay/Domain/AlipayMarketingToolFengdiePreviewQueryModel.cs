using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayMarketingToolFengdiePreviewQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMarketingToolFengdiePreviewQueryModel : AlipayObject
    {
        /// <summary>
        /// 欲查询的站点 ID
        /// </summary>
        [JsonProperty("activity_id")]
        public long ActivityId { get; set; }

        /// <summary>
        /// 作为当前操作者的空间成员用户名， 值为 origin_user_id（即创建空间成员接口的入参），应确保 operator 是参数 space_id 对应的空间成员
        /// </summary>
        [JsonProperty("operator")]
        public string Operator { get; set; }

        /// <summary>
        /// 欲查询的云凤蝶业务空间 ID
        /// </summary>
        [JsonProperty("space_id")]
        public string SpaceId { get; set; }
    }
}
