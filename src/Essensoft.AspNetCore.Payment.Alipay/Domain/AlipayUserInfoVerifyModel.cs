using System;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipayUserInfoVerifyModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipayUserInfoVerifyModel : AlipayObject
    {
        /// <summary>
        /// JSON字符串，格式如下： { principalInfo:{ userId: "用户的userId", logonId:"13812341234"}, subRequests:[ { type:"字段类型，支持的类型见后续说明", value:"字段值" } ] } 说明： （1）入参中的principalInfo信息用于指示待检查的用户，支持userId和logonId，优先看userId。 （2）subRequests为待检查的信息项，会与principalInfo所指示的用户留存在支付宝的信息进行匹配；数组类型，支持多种字段的校验；其中type为信息类型，value为信息值。 （3）type目前支持的类型（传参示例：mobile）: 手机：mobile 姓名：realName 证件号: certNo 证件类型: certType 用户类型: userType （4）certType取值枚举（传参示例，注意是字符串：0）: 0, 身份证 1, 护照 2, 军官证 3, 士兵证 4, 回乡证 5, 临时身份证 6, 户口簿 7, 警官证 8, 台胞证 9, 营业执照 10, 其它证件 11, 港澳居民来往内地通行证 12, 台湾居民来往大陆通行证 （5）userType取值枚举（传参示例，注意是字符串：2）： 1，企业类型 2，个人类型
        /// </summary>
        [JsonProperty("request")]
        public string Request { get; set; }
    }
}
