using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayDaoweiWeikeTaskviewQueryModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayDaoweiWeikeTaskviewQueryModel : AlipayObject
    {
        /// <summary>
        /// 当前城市城市码,精确到地级市级别.城市编码参考最新国家标准http://www.stats.gov.cn/tjsj/tjbz/xzqhdm/201703/t20170310_1471429.html
        /// </summary>
        [JsonProperty("city_code")]
        public string CityCode { get; set; }

        /// <summary>
        /// 第三方调用场景来源,由微客分配
        /// </summary>
        [JsonProperty("source")]
        public string Source { get; set; }
    }
}
