using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// IntelligentPromo Data Structure.
    /// </summary>
    public class IntelligentPromo : AlipayObject
    {
        /// <summary>
        /// 是否允许自动续期
        /// </summary>
        [JsonPropertyName("allow_auto_delay")]
        public bool AllowAutoDelay { get; set; }

        /// <summary>
        /// 审批状态。APPROVING：审批中；REJECTED：已驳回；PASS：已通过；（注意：修改接口无需传递审批状态）
        /// </summary>
        [JsonPropertyName("audit_status")]
        public string AuditStatus { get; set; }

        /// <summary>
        /// 请求幂等控制请求参数，该参数尽量比较复杂，建议使用uuid，否则触发幂等返回。
        /// </summary>
        [JsonPropertyName("create_request_no")]
        public string CreateRequestNo { get; set; }

        /// <summary>
        /// 当前创建人信息，如服务商替商户创建，则为服务商信息，销售小二创建，则为销售小二信息，商户小二创建，则为商户小二信息。（为了追溯创建人信息，请务必仔细填写）
        /// </summary>
        [JsonPropertyName("creator_info")]
        public PromoOperatorInfo CreatorInfo { get; set; }

        /// <summary>
        /// 智能活动描述
        /// </summary>
        [JsonPropertyName("desc")]
        public string Desc { get; set; }

        /// <summary>
        /// 活动扩展信息，通过《koubei.marketing.campaign.intelligent.promo.consult智能方案咨询接口》推荐出的方案扩展信息字段，调用《koubei.marketing.campaign.intelligent.promo.create创建智能方案》接口必须要原路带回，不能删减字段。
        /// </summary>
        [JsonPropertyName("ext_info")]
        public string ExtInfo { get; set; }

        /// <summary>
        /// 方案级别的效果预测，《koubei.marketing.campaign.intelligent.promo.create》创建接口中不需要传递
        /// </summary>
        [JsonPropertyName("forecast_effect")]
        public IntelligentPromoEffect ForecastEffect { get; set; }

        /// <summary>
        /// 智能营销活动下架的时间
        /// </summary>
        [JsonPropertyName("gmt_closed")]
        public string GmtClosed { get; set; }

        /// <summary>
        /// 智能营销活动的生效时间
        /// </summary>
        [JsonPropertyName("gmt_enabled")]
        public string GmtEnabled { get; set; }

        /// <summary>
        /// 智能营销活动的结束时间
        /// </summary>
        [JsonPropertyName("gmt_end")]
        public string GmtEnd { get; set; }

        /// <summary>
        /// 智能营销活动开始时间
        /// </summary>
        [JsonPropertyName("gmt_start")]
        public string GmtStart { get; set; }

        /// <summary>
        /// 智能营销商户子活动列表
        /// </summary>
        [JsonPropertyName("merchant_promos")]
        public List<InteligentMerchantPromo> MerchantPromos { get; set; }

        /// <summary>
        /// 智能营销活动对应的名称
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// 智能活动对应的归属人信息，商户活动对应商户信息
        /// </summary>
        [JsonPropertyName("owner_info")]
        public PromoOperatorInfo OwnerInfo { get; set; }

        /// <summary>
        /// 智能营销方案父id，如果需要续签智能营销活动，则会对于原有智能营销方案的id
        /// </summary>
        [JsonPropertyName("parent_promo_id")]
        public string ParentPromoId { get; set; }

        /// <summary>
        /// 智能营销活动对应的方案编号
        /// </summary>
        [JsonPropertyName("plan_id")]
        public string PlanId { get; set; }

        /// <summary>
        /// 智能营销方案id。《koubei.marketing.campaign.intelligent.promo.create》创建接口中这个参数不必传递，仅在查询接口中返回
        /// </summary>
        [JsonPropertyName("promo_id")]
        public string PromoId { get; set; }

        /// <summary>
        /// 营销活动详情列表，注意：（该参数20180125开始已不在维护，替代参数详见merchant_promos，如需接入替代参数，接之前先找开发负责人申请appid白名单）
        /// </summary>
        [JsonPropertyName("promos")]
        public List<IntelligentPromoDetail> Promos { get; set; }

        /// <summary>
        /// 智能营销活动状态。CREATED：已创建；ENABLED：已生效；CLOSED：已关闭；FINISHED：已完结；DISABLED:已失效（有两种情况会是失效状态，一种是服务商创建方案，商户驳回，一种是服务商创建方案，商户未确认，活动到期。）（注意：修改方案的动作不需要传递方案状态）
        /// </summary>
        [JsonPropertyName("status")]
        public string Status { get; set; }

        /// <summary>
        /// 该智能营销方案如果续签多次，则会返回该方案对应的所有智能营销子方案的promo_id
        /// </summary>
        [JsonPropertyName("sub_promo_ids")]
        public List<string> SubPromoIds { get; set; }

        /// <summary>
        /// 活动展示状态。已创建：CREATED；  REJECTED：创建被驳回；ENABLING：生效中；ONLINE_WAIT_CONFIRM：上架待确认；PUBLISHED：已发布（活动未到开始时间）；ENABLED：已发布已开始；OFFLINE_WAIT_CONFIRM：下架待确认；CLOSING：下架中；CLOSED：已下架（人为干预下架）；FINISHED：已结束（活动到期自然结束）；MODIFYING：修改中；MODIFY_WAIT_CONFIRM：修改待确认；DISABLED：已失效  （注意：修改接口子状态参数不能传递）
        /// </summary>
        [JsonPropertyName("sub_status")]
        public string SubStatus { get; set; }

        /// <summary>
        /// 智能营销活动对应的方案中的模板编号
        /// </summary>
        [JsonPropertyName("template_id")]
        public string TemplateId { get; set; }

        /// <summary>
        /// 智能活动类型，值如下：RECOMMENDATION：系统推荐；REGISTRATION：报名。在创建时，这个字段需要ISV自己进行决策，在推荐接口会返回优惠力度，比如代金券面额等信息，ISV判断如果优惠力度比这个大或者相同，就用RECOMMENDATION，其他情况用REGISTRATION，如推荐力度大于实际创建传过来的优惠力度，则创建的时候系统会自动将RECOMMENDATION改为REGISTRATION
        /// </summary>
        [JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
