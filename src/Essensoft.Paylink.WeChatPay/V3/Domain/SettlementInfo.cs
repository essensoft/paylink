using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.Paylink.WeChatPay.V3.Domain
{
    /// <summary>
    /// 结算规则
    /// </summary>
    public class SettlementInfo : WeChatPayObject
    {
        /// <summary>
        /// 入驻结算规则ID
        /// </summary>
        /// <remarks>
        /// 请选择结算规则ID，详细参见《费率结算规则对照表》。
        /// <para>示例值：719</para>
        /// </remarks>
        [JsonPropertyName("settlement_id")]
        public string SettlementId { get; set; }

        /// <summary>
        /// 所属行业
        /// </summary>
        /// <remarks>
        /// 请填写所属行业名称，详细参见《费率结算规则对照表》。
        /// <para>示例值：餐饮</para>
        /// </remarks>
        [JsonPropertyName("qualification_type")]
        public string QualificationType { get; set; }

        /// <summary>
        /// 特殊资质图片
        /// </summary>
        /// <remarks>
        /// 1、根据所属行业的特殊资质要求提供，详情查看《费率结算规则对照表》。
        /// 2、请提供为“申请商家主体”所属的特殊资质，可授权使用总公司/分公司的特殊资 质；
        /// 3、最多可上传5张照片，请填写通过《图片上传API》预先上传图片生成好的MediaID。
        /// <para>示例值：0P3ng6KTIW4-Q_l2FjmFJBZR9FwczhJehHhAZN6BKXQPcs-VvdSo</para>
        /// </remarks>
        [JsonPropertyName("qualifications")]
        public List<string> Qualifications { get; set; }

        /// <summary>
        /// 优惠费率活动ID
        /// </summary>
        /// <remarks>
        /// 选择指定活动ID，如果商户有意向报名优惠费率活动，该字段必填。详细参见《优惠费率活动对照表》。
        /// <para>示例值：20191030111cff5b5e</para>
        /// </remarks>
        [JsonPropertyName("activities_id")]
        public string ActivitiesId { get; set; }

        /// <summary>
        /// 优惠费率活动值
        /// </summary>
        /// <remarks>
        /// 根据优惠费率活动规则，若填写“优惠费率活动ID”，则该字段必填。由服务商自定义填写，支持两个小数点，需在优惠费率活动ID指定费率范围内，如0.6%（接口无需传%，只需传数字）。
        /// <para>示例值：0.6</para>
        /// </remarks>
        [JsonPropertyName("activities_rate")]
        public string ActivitiesRate { get; set; }

        /// <summary>
        /// 优惠费率活动补充材料
        /// </summary>
        /// <remarks>
        /// 1、根据所选优惠费率活动，提供相关材料，详细参见《优惠费率活动对照表》。
        /// 2、最多可上传5张照片，请填写通过《图片上传API》预先上传图片生成好的MediaID。
        /// </remarks>
        [JsonPropertyName("activities_additions")]
        public List<string> ActivitiesAdditions { get; set; }
    }
}
