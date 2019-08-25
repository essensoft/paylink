using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayMarketingToolFengdieEditorGetModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayMarketingToolFengdieEditorGetModel : AlipayObject
    {
        /// <summary>
        /// 欲唤起的站点 ID
        /// </summary>
        [JsonProperty("activity_id")]
        public long ActivityId { get; set; }

        /// <summary>
        /// 作为当前操作者的空间成员用户名， 值为 origin_user_id（即创建空间成员接口的入参），应确保 operator 是参数 space_id 对应的空间成员
        /// </summary>
        [JsonProperty("operator")]
        public string Operator { get; set; }

        /// <summary>
        /// 在云凤蝶编辑器中点击“发布”按钮后，如果发布成功则跳转到该地址
        /// </summary>
        [JsonProperty("redirect_url")]
        public string RedirectUrl { get; set; }

        /// <summary>
        /// 欲唤起的站点所归属的空间 ID
        /// </summary>
        [JsonProperty("space_id")]
        public string SpaceId { get; set; }
    }
}
