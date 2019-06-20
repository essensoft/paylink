using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// SsdataDataserviceRiskRtopQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class SsdataDataserviceRiskRtopQueryModel : AlipayObject
    {
        /// <summary>
        /// rowkeys+不需要唯一+蚁盾风险大脑项目，监管科技平台需要通过open api接口查询后端的反洗钱数据+非枚举+由用户检索的数据组成的参数+无特殊说明
        /// </summary>
        [JsonProperty("rowkeys")]
        public string Rowkeys { get; set; }
    }
}
