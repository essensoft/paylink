using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.Paylink.WeChatPay.V3.Domain;

namespace Essensoft.Paylink.WeChatPay.V3.Response
{
    /// <summary>
    /// 电商收付通 - 通过申请单ID查询申请状态 - 返回参数
    /// </summary>
    /// <remarks>
    /// <para><a href="https://pay.weixin.qq.com/wiki/doc/apiv3_partner/apis/chapter7_1_2.shtml">电商收付通 - 通过申请单ID查询申请状态</a> - 最新更新时间：2022.04.08</para>
    /// </remarks>
    public class WeChatPayEcommerceApplymentsQueryResponse : WeChatPayResponse
    {
        /// <summary>
        /// 申请状态
        /// </summary>
        /// <remarks>
        /// 枚举值：
        /// CHECKING：资料校验中
        /// ACCOUNT_NEED_VERIFY：待账户验证
        /// AUDITING：审核中
        /// REJECTED：已驳回
        /// NEED_SIGN：待签约
        /// FINISH：完成
        /// FROZEN：已冻结
        /// CANCELED：已作废
        /// <para>示例值：FINISH</para>
        /// </remarks>
        [JsonPropertyName("applyment_state")]
        public string ApplymentState { get; set; }

        /// <summary>
        /// 签约状态
        /// </summary>
        /// <remarks>
        /// 1、UNSIGNED：未签约。该状态下，电商平台可查询获取签约链接，引导二级商户的超级管理员完成签约；
        /// 2、SIGNED ：已签约。指二级商户的超级管理员已完成签约。注意：若申请单被驳回，商户修改了商户主体名称、法人名称、超级管理员信息、主体类型等信息，则需重新签约。
        /// 3、NOT_SIGNABLE：不可签约。该状态下，暂不支持超级管理员签约。一般为申请单处于已驳回、已冻结、机器校验中状态，无法签约。
        /// <para>示例值：SIGNED</para>
        /// </remarks>
        [JsonPropertyName("applyment_state_desc")]
        public string ApplymentStateDesc { get; set; }

        /// <summary>
        /// 签约链接
        /// </summary>
        /// <remarks>
        /// 1、当申请状态为NEED_SIGN 或 签约状态为UNSIGNED时返回，该链接为永久有效；
        /// 2、申请单中的超级管理者，需用已实名认证的微信扫码打开，完成签约。
        /// <para>示例值：https://pay.weixin.qq.com/public/apply4ec_sign/s?applymentId=2000002126198476&sign=b207b673049a32c858f3aabd7d27c7ec</para>
        /// </remarks>
        [JsonPropertyName("sign_url")]
        public string SignUrl { get; set; }

        /// <summary>
        /// 电商平台二级商户号
        /// </summary>
        /// <remarks>
        /// 当申请状态为NEED_SIGN或FINISH时才返回。
        /// <para>示例值：1542488631</para>
        /// </remarks>
        [JsonPropertyName("sub_mchid")]
        public string SubMchid { get; set; }

        /// <summary>
        /// 汇款账户验证信息
        /// </summary>
        /// <remarks>
        /// 当申请状态为ACCOUNT_NEED_VERIFY 时有返回，可根据指引汇款，完成账户验证。
        /// </remarks>
        [JsonPropertyName("account_validation")]
        public EcommerceAccountValidation EcommerceAccountValidation { get; set; }

        /// <summary>
        /// 驳回原因详情
        /// </summary>
        /// <remarks>
        /// 各项资料的审核情况。当申请状态为REJECTED或 FROZEN时才返回。
        /// </remarks>
        [JsonPropertyName("audit_detail")]
        public List<EcommerceAuditDetail> EcommerceAuditDetail { get; set; }

        /// <summary>
        /// 法人验证链接
        /// </summary>
        /// <remarks>
        /// 1、当申请状态为
        /// ACCOUNT_NEED_VERIFY，且通过系统校验的申请单，将返回链接。
        /// 2、建议将链接转为二维码展示，让商户法人用微信扫码打开，完成账户验证。
        /// 注：商户申请单进入审核状态后，微信侧会校验法人证件号码是否跟营业执照匹配，若匹配，返回该字段 ; 若不匹配，不支持法人扫码验证，不返回该字段。
        /// <para>示例值：http://pay.weixin.qq.com/public/apply4ec_sign/s?applymentId=2000002126198476&sign=b207b673049a32c858f3aabd7d27c7ec</para>
        /// </remarks>
        [JsonPropertyName("legal_validation_url")]
        public string LegalValidationUrl { get; set; }

        /// <summary>
        /// 业务申请编号
        /// </summary>
        /// <remarks>
        /// 提交接口填写的业务申请编号。
        /// <para>示例值：APPLYMENT_00000000001</para>
        /// </remarks>
        [JsonPropertyName("out_request_no")]
        public string OutRequestNo { get; set; }

        /// <summary>
        /// 微信支付申请单号
        /// </summary>
        /// <remarks>
        /// 微信支付分配的申请单号。
        /// <para>示例值：2000002124775691</para>
        /// </remarks>
        [JsonPropertyName("applyment_id")]
        public ulong ApplymentId { get; set; }
    }
}
