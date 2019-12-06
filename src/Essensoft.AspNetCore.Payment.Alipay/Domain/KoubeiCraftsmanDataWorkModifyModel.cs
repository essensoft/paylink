using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KoubeiCraftsmanDataWorkModifyModel Data Structure.
    /// </summary>
    public class KoubeiCraftsmanDataWorkModifyModel : AlipayObject
    {
        /// <summary>
        /// 服务商、服务商员工、商户、商户员工等口碑角色操作时必填，对应为 koubei.member.data.oauth.query 中的 auth_code，默认有效期24小时；ISV自身角色操作的时候，无需传该参数
        /// </summary>
        [JsonPropertyName("auth_code")]
        public string AuthCode { get; set; }

        /// <summary>
        /// 作品标题。不能出现网络敏感词，异步审核，审核不通过会删除作品。不会回调isv
        /// </summary>
        [JsonPropertyName("title")]
        public string Title { get; set; }

        /// <summary>
        /// 口碑手艺人作品id，通过查询手艺人作品信息接口koubei.craftsman.data.work.batchquery获取work_id
        /// </summary>
        [JsonPropertyName("work_id")]
        public string WorkId { get; set; }
    }
}
