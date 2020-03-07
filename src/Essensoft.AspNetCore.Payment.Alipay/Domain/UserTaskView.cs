using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// UserTaskView Data Structure.
    /// </summary>
    public class UserTaskView : AlipayObject
    {
        /// <summary>
        /// 微客身份证号码。加密后的值
        /// </summary>
        [JsonPropertyName("identification")]
        public string Identification { get; set; }

        /// <summary>
        /// 微客手机号码,在没有手机号的情况下，返回99999999999。加密后的值
        /// </summary>
        [JsonPropertyName("phone_number")]
        public string PhoneNumber { get; set; }

        /// <summary>
        /// 劳务费,单位元
        /// </summary>
        [JsonPropertyName("service_charge")]
        public string ServiceCharge { get; set; }

        /// <summary>
        /// 任务编号
        /// </summary>
        [JsonPropertyName("task_id")]
        public long TaskId { get; set; }

        /// <summary>
        /// 微客支付宝用户编号
        /// </summary>
        [JsonPropertyName("user_id")]
        public string UserId { get; set; }

        /// <summary>
        /// 用户任务id
        /// </summary>
        [JsonPropertyName("user_task_id")]
        public string UserTaskId { get; set; }

        /// <summary>
        /// 微客用户编号
        /// </summary>
        [JsonPropertyName("weike_user_id")]
        public long WeikeUserId { get; set; }

        /// <summary>
        /// 微客用户名称，加密后的值
        /// </summary>
        [JsonPropertyName("weike_user_name")]
        public string WeikeUserName { get; set; }
    }
}
