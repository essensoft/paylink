using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// MybankCreditSceneprodLoanApplyModel Data Structure.
    /// </summary>
    public class MybankCreditSceneprodLoanApplyModel : AlipayObject
    {
        /// <summary>
        /// 支付宝版本号
        /// </summary>
        [JsonPropertyName("alipay_version")]
        public string AlipayVersion { get; set; }

        /// <summary>
        /// 订单审核结果回调地址
        /// </summary>
        [JsonPropertyName("back_url")]
        public string BackUrl { get; set; }

        /// <summary>
        /// 数据来源渠道，从服务窗调用开放平台接口的是OPENAPI, 手机端为APP，天猫调用是TMALL
        /// </summary>
        [JsonPropertyName("channel")]
        public string Channel { get; set; }

        /// <summary>
        /// 业务订单扩展字段，根据机构不同填入的参数会有区别
        /// </summary>
        [JsonPropertyName("ext_param")]
        public string ExtParam { get; set; }

        /// <summary>
        /// 扩展字段实体，规范了通用的扩展字段内的信息，便于调用方使用，与ext_param作用相同。与ext_param有同名字段冲突时以ext_param_info中内容为准。
        /// </summary>
        [JsonPropertyName("ext_param_info")]
        public SceneExtParam ExtParamInfo { get; set; }

        /// <summary>
        /// 出资机构在网商的角色号（ipRoleId）, 下单时不确定可以不填
        /// </summary>
        [JsonPropertyName("finance_inst_iprole_id")]
        public string FinanceInstIproleId { get; set; }

        /// <summary>
        /// 贷款金额，单位：分 。如果在下单时不确定可以不传
        /// </summary>
        [JsonPropertyName("loan_amt")]
        public string LoanAmt { get; set; }

        /// <summary>
        /// 贷款期数，单位：月，如果在下单时不确定可以不传
        /// </summary>
        [JsonPropertyName("loan_period")]
        public string LoanPeriod { get; set; }

        /// <summary>
        /// 订单类型
        /// </summary>
        [JsonPropertyName("order_type")]
        public string OrderType { get; set; }

        /// <summary>
        /// 机构编码，机构接入场景金融平台时分配，固定值
        /// </summary>
        [JsonPropertyName("org_code")]
        public string OrgCode { get; set; }

        /// <summary>
        /// 外部平台订单号,64个字符以内、只能包含字母、数字、下划线；需保证在外部平台端不重复
        /// </summary>
        [JsonPropertyName("out_order_no")]
        public string OutOrderNo { get; set; }

        /// <summary>
        /// 产品编码，场景金融平台给机构提供的产品编码
        /// </summary>
        [JsonPropertyName("product_code")]
        public string ProductCode { get; set; }

        /// <summary>
        /// 新车车贷  01023200002000002828  二手车车贷  01023200002000002931  转分期回租租金贷  01023200002000003090  新车直租租金贷  01023200002000003206  新车回租租金贷  01023200002000003394  二手车直租租金贷  01023200002000002932  二手车回租租金贷  01023200002000003531
        /// </summary>
        [JsonPropertyName("sales_product_code")]
        public string SalesProductCode { get; set; }

        /// <summary>
        /// 场景代码，用于区分后续业务流程
        /// </summary>
        [JsonPropertyName("scene")]
        public string Scene { get; set; }

        /// <summary>
        /// 外部站点，比如：ALIPAY：支付宝站点，MYBANK：银行会员，B2B_CN：B2B中文站，B2B_EN：B2B国际站，TAOBAO：淘宝
        /// </summary>
        [JsonPropertyName("site")]
        public string Site { get; set; }

        /// <summary>
        /// 外部站点的userid，比如支付宝userid
        /// </summary>
        [JsonPropertyName("site_user_id")]
        public string SiteUserId { get; set; }

        /// <summary>
        /// 核身VID
        /// </summary>
        [JsonPropertyName("verify_id")]
        public string VerifyId { get; set; }
    }
}
