using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayInsSceneApplicationApplyModel Data Structure.
    /// </summary>
    public class AlipayInsSceneApplicationApplyModel : AlipayObject
    {
        /// <summary>
        /// 用户参与的活动ID
        /// </summary>
        [JsonPropertyName("activity_id")]
        public string ActivityId { get; set; }

        /// <summary>
        /// 投保人
        /// </summary>
        [JsonPropertyName("applicant")]
        public InsPerson Applicant { get; set; }

        /// <summary>
        /// 支付账单流水的标题
        /// </summary>
        [JsonPropertyName("bill_title")]
        public string BillTitle { get; set; }

        /// <summary>
        /// 投保参数 ,每个产品特有的投保参数,如航空险的航班信息;标准json格式
        /// </summary>
        [JsonPropertyName("biz_data")]
        public string BizData { get; set; }

        /// <summary>
        /// 保险产品销售单元编码
        /// </summary>
        [JsonPropertyName("csu_no")]
        public string CsuNo { get; set; }

        /// <summary>
        /// 生效时间
        /// </summary>
        [JsonPropertyName("effect_start_time")]
        public string EffectStartTime { get; set; }

        /// <summary>
        /// 标的信息， 保险标的物，产品责任信息
        /// </summary>
        [JsonPropertyName("ins_objects")]
        public List<InsObject> InsObjects { get; set; }

        /// <summary>
        /// 被保险人
        /// </summary>
        [JsonPropertyName("insureds")]
        public List<InsPerson> Insureds { get; set; }

        /// <summary>
        /// 商户生成的外部投保业务号,必须保证唯一
        /// </summary>
        [JsonPropertyName("out_biz_no")]
        public string OutBizNo { get; set; }

        /// <summary>
        /// 险种保障期限,数字+"Y/M/D"结尾,非固定期限险种或多固定期限险种必填
        /// </summary>
        [JsonPropertyName("period")]
        public string Period { get; set; }

        /// <summary>
        /// 实际保费，询价接口获取的保费通过投保接口传递进来。投保接口会对传入的保费进行验证。传入的保费和核价的值不一样投保失败
        /// </summary>
        [JsonPropertyName("premium")]
        public long Premium { get; set; }

        /// <summary>
        /// 产品编码;由蚂蚁保险平台分配,商户通过该产品编码投保特定的保险产品（如饿了么外卖延误险）
        /// </summary>
        [JsonPropertyName("prod_code")]
        public string ProdCode { get; set; }

        /// <summary>
        /// 推荐流水号
        /// </summary>
        [JsonPropertyName("recom_flow_no")]
        public string RecomFlowNo { get; set; }

        /// <summary>
        /// 渠道来源
        /// </summary>
        [JsonPropertyName("source")]
        public string Source { get; set; }

        /// <summary>
        /// 跟保单相关的干系人
        /// </summary>
        [JsonPropertyName("stake_holders")]
        public List<InsPerson> StakeHolders { get; set; }

        /// <summary>
        /// 保额值,保额类型为枚举的时候是一个枚举值,当为金额类型时单位为分
        /// </summary>
        [JsonPropertyName("sum_insured")]
        public long SumInsured { get; set; }
    }
}
