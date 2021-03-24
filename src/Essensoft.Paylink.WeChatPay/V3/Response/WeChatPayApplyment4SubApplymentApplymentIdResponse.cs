using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.Paylink.WeChatPay.V3.Domain;

namespace Essensoft.Paylink.WeChatPay.V3.Response
{
    /// <summary>
    /// 特约商户进件 - 查询申请单状态 - 返回参数
    /// </summary>
    /// <remarks>
    /// <para><a href="https://pay.weixin.qq.com/wiki/doc/apiv3_partner/apis/chapter11_1_2.shtml">特约商户进件 - 查询申请单状态API</a> - 最新更新时间：2020.2.11</para>
    /// </remarks>
    public class WeChatPayApplyment4SubApplymentApplymentIdResponse : WeChatPayResponse
    {
        /// <summary>
        /// 业务申请编号
        /// </summary>
        /// <remarks>
        /// 1、只能由数字、字母或下划线组成，建议前缀为服务商商户号。
        /// 2、服务商自定义的唯一编号。
        /// 3、每个编号对应一个申请单，每个申请单审核通过后生成一个微信支付商户号。
        /// 4、若申请单被驳回，可填写相同的“业务申请编号”，即可覆盖修改原申请单信息。
        /// <para>示例值：1900013511_10000</para>
        /// </remarks>
        [JsonPropertyName("business_code")]
        public string BusinessCode { get; set; }

        /// <summary>
        /// 微信支付申请单号
        /// </summary>
        /// <remarks>
        /// 微信支付分配的申请单号。
        /// <para>示例值：2000002124775691</para>
        /// </remarks>
        [JsonPropertyName("applyment_id")]
        public string ApplymentId { get; set; }

        /// <summary>
        /// 特约商户号
        /// </summary>
        /// <remarks>
        /// 特约商户号，当申请单状态为APPLYMENT_STATE_FINISHED时才返回。
        /// <para>示例值：1234567890</para>
        /// </remarks>
        [JsonPropertyName("sub_mchid")]
        public string SubMchid { get; set; }

        /// <summary>
        /// 超级管理员签约链接
        /// </summary>
        /// <remarks>
        /// 1、超级管理员用微信扫码，关注“微信支付商家助手”公众号后，公众号将自动发送签约消息；超管需点击消息，根据指引完成核对联系信息、账户验证、签约等操作。
        /// 2、超管完成核对联系信息，后续申请单进度可通过公众号自动通知超级管理员。
        /// <para>示例值：https://pay.weixin.qq.com/public/apply4ec_sign/s?applymentId=2000002126198476&amp;sign=b207b673049a32c858f3aabd7d27c7ec</para>
        /// </remarks>
        [JsonPropertyName("sign_url")]
        public string SignUrl { get; set; }

        /// <summary>
        /// 申请单状态
        /// </summary>
        /// <remarks>
        /// 1、APPLYMENT_STATE_EDITTING（编辑中）：提交申请发生错误导致，请尝试重新提交。
        /// 2、APPLYMENT_STATE_AUDITING（审核中）：申请单正在审核中，超级管理员用微信打开“签约链接”，完成绑定微信号后，申请单进度将通过微信公众号通知超级管理员，引导完成后续步骤。
        /// 3、APPLYMENT_STATE_REJECTED（已驳回）：请按照驳回原因修改申请资料，超级管理员用微信打开“签约链接”，完成绑定微信号，后续申请单进度将通过微信公众号通知超级管理员。
        /// 4、APPLYMENT_STATE_TO_BE_CONFIRMED（待账户验证）：请超级管理员使用微信打开返回的“签约链接”，根据页面指引完成账户验证。
        /// 5、APPLYMENT_STATE_TO_BE_SIGNED（待签约）：请超级管理员使用微信打开返回的“签约链接”，根据页面指引完成签约。
        /// 6、APPLYMENT_STATE_SIGNING（开通权限中）：系统开通相关权限中，请耐心等待。
        /// 7、APPLYMENT_STATE_FINISHED（已完成）：商户入驻申请已完成。
        /// 8、APPLYMENT_STATE_CANCELED（已作废）：申请单已被撤销。
        /// <para>示例值：APPLYMENT_STATE_FINISHED</para>
        /// </remarks>
        [JsonPropertyName("applyment_state")]
        public string ApplymentState { get; set; }

        /// <summary>
        /// 申请状态描述
        /// </summary>
        /// <remarks>
        /// 申请状态描述
        /// <para>示例值：审核中</para>
        /// </remarks>
        [JsonPropertyName("applyment_state_msg")]
        public string ApplymentStateMsg { get; set; }

        /// <summary>
        /// 驳回原因详情
        /// </summary>
        /// <remarks>
        /// 各项资料的审核情况，当申请状态为APPLYMENT_STATE_REJECTED时才返回。
        /// </remarks>
        [JsonPropertyName("audit_detail")]
        public List<AuditDetail> AuditDetail { get; set; }
    }
}
