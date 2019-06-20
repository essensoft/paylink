using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// BoothContentInfoModel Data Structure.
    /// </summary>
    [Serializable]
    public class BoothContentInfoModel : AlipayObject
    {
        /// <summary>
        /// 展台名称
        /// </summary>
        [JsonProperty("booth")]
        public string Booth { get; set; }

        /// <summary>
        /// 内容信息列表
        /// </summary>
        [JsonProperty("content_info_list")]
        public List<ContentInfoModel> ContentInfoList { get; set; }
    }
}
