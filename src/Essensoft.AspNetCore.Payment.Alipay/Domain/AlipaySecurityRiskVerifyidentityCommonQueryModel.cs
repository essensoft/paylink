using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipaySecurityRiskVerifyidentityCommonQueryModel Data Structure.
    /// </summary>
    public class AlipaySecurityRiskVerifyidentityCommonQueryModel : AlipayObject
    {
        /// <summary>
        /// 根据不同的值选择查询接口的查询类型： TB_BIOPAY_MENU代表查询手淘中用户的生物支付开通数据
        /// </summary>
        [JsonPropertyName("cq_type")]
        public string CqType { get; set; }

        /// <summary>
        /// {   "uidType":"taobao",   "viData": {     "bmi": "3.60.0:13434331200,32774,2088612430858603",     "sfp": "true",     "secData": {       "rt": "0",       "ap": "",       "pn": "com.alipay.iphoneclient",       "bi": "4#1#2#0#2#1#0#6#0#1#0;",       "dv": "17",       "ai": "2#2#0#2#1#0#6;",       "pm": "iPhone11#8",       "di": "FFFFFFFF2E0DEBB9ECF34D9C8F666C7C560B1F1C"     },     "dm": "iPhone11,8",     "viv": "3.1.85.100",     "tid": "89b7b78a10b4bc31ebf62a314b791dbf3ce6cf7538aaca3049a4cde35d792985",     "deviceType":"android/ios"   } }
        /// </summary>
        [JsonPropertyName("env_data")]
        public string EnvData { get; set; }

        /// <summary>
        /// 支付宝uid或者手淘uid，根据类型可以传入不同的值
        /// </summary>
        [JsonPropertyName("user_id")]
        public string UserId { get; set; }
    }
}
