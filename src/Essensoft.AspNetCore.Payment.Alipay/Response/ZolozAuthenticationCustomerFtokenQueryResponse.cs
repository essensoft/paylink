using System.Collections.Generic;
using Essensoft.AspNetCore.Payment.Alipay.Domain;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// ZolozAuthenticationCustomerFtokenQueryResponse.
    /// </summary>
    public class ZolozAuthenticationCustomerFtokenQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 图片base64 encodeString
        /// </summary>
        [JsonProperty("authimg_base_64")]
        public string AuthimgBase64 { get; set; }

        /// <summary>
        /// 支付宝uid
        /// </summary>
        [JsonProperty("uid")]
        public string Uid { get; set; }

        /// <summary>
        /// 用户名和手机号信息返回的列表
        /// </summary>
        [JsonProperty("uid_tel_pair_list")]
        public List<ZhubUidTelPair> UidTelPairList { get; set; }
    }
}
