using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayOpenMiniAmpeCategoryBatchqueryModel Data Structure.
    /// </summary>
    public class AlipayOpenMiniAmpeCategoryBatchqueryModel : AlipayObject
    {
        /// <summary>
        /// 场景码，申请后平台分配，必填
        /// </summary>
        [JsonPropertyName("scene_code")]
        public string SceneCode { get; set; }
    }
}
