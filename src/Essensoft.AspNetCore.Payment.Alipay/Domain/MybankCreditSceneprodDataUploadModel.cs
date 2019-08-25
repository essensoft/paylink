using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// MybankCreditSceneprodDataUploadModel Data Structure.
    /// </summary>
    [Serializable]
    public class MybankCreditSceneprodDataUploadModel : AlipayObject
    {
        /// <summary>
        /// 申请单号
        /// </summary>
        [JsonProperty("app_seqno")]
        public string AppSeqno { get; set; }

        /// <summary>
        /// STRICT_CHECK,NO_CHECK  严格检验，非严格校验
        /// </summary>
        [JsonProperty("data_config")]
        public string DataConfig { get; set; }

        /// <summary>
        /// data_content 是风控需要的用户场景数据，统一采用json格式。不同行业内容不同。目前这个接口为定向服务机构和行业(汽车和物流行业)，不是完全开放的接口。    机构传入org_code和product_code,场景端根据两码和行业映射关系判断行业,从而对传入的场景参数进行校验。    目前只接入汽车行业，下面是汽车行业进件模版地址。  https://yuque.antfin-inc.com/scene/dq09hu/zsr5zx
        /// </summary>
        [JsonProperty("data_content")]
        public string DataContent { get; set; }

        /// <summary>
        /// 机构码，接入时场景分配
        /// </summary>
        [JsonProperty("org_code")]
        public string OrgCode { get; set; }

        /// <summary>
        /// 产品码，机构接入时接入
        /// </summary>
        [JsonProperty("product_code")]
        public string ProductCode { get; set; }
    }
}
