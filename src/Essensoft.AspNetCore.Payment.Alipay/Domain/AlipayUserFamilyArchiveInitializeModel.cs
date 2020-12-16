using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayUserFamilyArchiveInitializeModel Data Structure.
    /// </summary>
    public class AlipayUserFamilyArchiveInitializeModel : AlipayObject
    {
        /// <summary>
        /// 家庭档案id
        /// </summary>
        [JsonPropertyName("archive_id_list")]
        public List<string> ArchiveIdList { get; set; }

        /// <summary>
        /// 最大选择家人档案数量，范围[0,10]区间
        /// </summary>
        [JsonPropertyName("max_archives_cnt")]
        public long MaxArchivesCnt { get; set; }

        /// <summary>
        /// 最小选择家人档案数量，范围[0,10]区间
        /// </summary>
        [JsonPropertyName("min_archives_cnt")]
        public long MinArchivesCnt { get; set; }

        /// <summary>
        /// 外部业务号
        /// </summary>
        [JsonPropertyName("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 授权回调地址，和应用在门户上设置的“授权回调地址”保持一致，必须满足URI规范，且不能携带参数
        /// </summary>
        [JsonPropertyName("redirect_uri")]
        public string RedirectUri { get; set; }

        /// <summary>
        /// 家庭档案组件模板id，模板包括定制化的字段、定制化的展示文案和用户协议等等。每个业务方需要用户家人信息的字段不一样，核验的方式也会有差异，需要联系产品负责人申请
        /// </summary>
        [JsonPropertyName("template_id")]
        public string TemplateId { get; set; }
    }
}
