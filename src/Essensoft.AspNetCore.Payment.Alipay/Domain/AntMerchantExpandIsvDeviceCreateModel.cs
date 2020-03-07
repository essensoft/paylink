using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AntMerchantExpandIsvDeviceCreateModel Data Structure.
    /// </summary>
    public class AntMerchantExpandIsvDeviceCreateModel : AlipayObject
    {
        /// <summary>
        /// 机具使用的业务场景：目前只支持团餐：CATERING_DEVICE
        /// </summary>
        [JsonPropertyName("biz_type")]
        public string BizType { get; set; }

        /// <summary>
        /// 渠道商下的服务商pid，例如云纵名下服务商
        /// </summary>
        [JsonPropertyName("channel_isv_pid")]
        public string ChannelIsvPid { get; set; }

        /// <summary>
        /// 机具物流配送信息
        /// </summary>
        [JsonPropertyName("delivery_info")]
        public DeliveryInfo DeliveryInfo { get; set; }

        /// <summary>
        /// 申请的机具模板列表
        /// </summary>
        [JsonPropertyName("device_list")]
        public List<DeviceApplyTemplate> DeviceList { get; set; }

        /// <summary>
        /// 申请人联系方式，须是7到12位电话号码
        /// </summary>
        [JsonPropertyName("operator_contact")]
        public string OperatorContact { get; set; }

        /// <summary>
        /// 申请人名称，至少需要一个汉字
        /// </summary>
        [JsonPropertyName("operator_name")]
        public string OperatorName { get; set; }

        /// <summary>
        /// 商户PID
        /// </summary>
        [JsonPropertyName("pid")]
        public string Pid { get; set; }

        /// <summary>
        /// 申请原因描述
        /// </summary>
        [JsonPropertyName("reason")]
        public string Reason { get; set; }

        /// <summary>
        /// 门店ID，从成功创建门店的通知里获取
        /// </summary>
        [JsonPropertyName("shop_id")]
        public string ShopId { get; set; }

        /// <summary>
        /// 申请用途详细说明，比如学校名称
        /// </summary>
        [JsonPropertyName("usage_detail")]
        public string UsageDetail { get; set; }

        /// <summary>
        /// 机具申请用途，团餐场景取值如下      PRIMARY_SCHOOL：小学；      JUNIOR_HIGH_SCHOOL：初中；      SENIOR_HIGH_SCHOOL：高中；      SECONDARY_VOCATIONAL_SCHOOL：中职；      VOCATIONAL_TECHNICAL_COLLEGE：职业技术学院；      UNIVERSITY：大学；            COMPANY：企业；      INDUSTRIAL_PARK：园区；      GOVERNMENT：政府机关；      HOSPITAL：医院；      FOOD_COURT：美食广场；      OTHER：其它；
        /// </summary>
        [JsonPropertyName("usage_type")]
        public string UsageType { get; set; }
    }
}
