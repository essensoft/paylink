using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Alipay.Domain
{
    /// <summary>
    /// ZhimaMerchantDataUploadInitializeModel Data Structure.
    /// </summary>
    public class ZhimaMerchantDataUploadInitializeModel : AlipayObject
    {
        /// <summary>
        /// 数据应用的场景编码 ，场景码和场景名称（数字为场景码）如下：  1:负面披露  2:信用足迹  3:负面+足迹  4:信用守护  5:负面+守护  6:足迹+守护  7:负面+足迹+守护  8:数据反馈  32:骑行
        /// </summary>
        [JsonProperty("scene_code")]
        public string SceneCode { get; set; }
    }
}
