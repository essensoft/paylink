using System;
using System.Xml.Serialization;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// ZhimaMerchantDataUploadInitializeModel Data Structure.
    /// </summary>
    [Serializable]
    public class ZhimaMerchantDataUploadInitializeModel : AlipayObject
    {
        /// <summary>
        /// 芝麻平台服务商模式下的二级商户标识，如果是直连商户调用该接口，不需要设置
        /// </summary>
        [JsonProperty("linked_merchant_id")]
        [XmlElement("linked_merchant_id")]
        public string LinkedMerchantId { get; set; }

        /// <summary>
        /// 数据应用的场景编码，场景码和场景名称（数字或字符串为场景码）如下：  8：数据反馈  32：骑行  CAR_RENTING：租车行业解决方案
        /// </summary>
        [JsonProperty("scene_code")]
        [XmlElement("scene_code")]
        public string SceneCode { get; set; }
    }
}
