using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Alipay.Domain
{
    /// <summary>
    /// DisplayConfig Data Structure.
    /// </summary>
    public class DisplayConfig : AlipayObject
    {
        /// <summary>
        /// 券的宣传语  含圈人的直领活动，且投放渠道选择了支付成功页或店铺的情况下必填
        /// </summary>
        [JsonProperty("slogan")]
        public string Slogan { get; set; }

        /// <summary>
        /// 券的宣传图片文件ID  含圈人的直领活动，且投放渠道选择了店铺的情况下必填
        /// </summary>
        [JsonProperty("slogan_img")]
        public string SloganImg { get; set; }
    }
}
