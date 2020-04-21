using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayEcoAcceptanceRequestCreateModel Data Structure.
    /// </summary>
    public class AlipayEcoAcceptanceRequestCreateModel : AlipayObject
    {
        /// <summary>
        /// 用户ID
        /// </summary>
        [JsonPropertyName("accetor_id")]
        public string AccetorId { get; set; }

        /// <summary>
        /// 用户名字、称呼等
        /// </summary>
        [JsonPropertyName("accetor_nick")]
        public string AccetorNick { get; set; }

        /// <summary>
        /// 用户类型，淘宝账户
        /// </summary>
        [JsonPropertyName("accetor_user_type")]
        public string AccetorUserType { get; set; }

        /// <summary>
        /// 用例ID
        /// </summary>
        [JsonPropertyName("case_id")]
        public string CaseId { get; set; }

        /// <summary>
        /// 用例需要的参数，可以采用这种结构
        /// </summary>
        [JsonPropertyName("params")]
        public string Params { get; set; }

        /// <summary>
        /// 任务ID
        /// </summary>
        [JsonPropertyName("task_id")]
        public string TaskId { get; set; }
    }
}
