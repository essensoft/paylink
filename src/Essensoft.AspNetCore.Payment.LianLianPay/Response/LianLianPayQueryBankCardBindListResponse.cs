using System.Collections.Generic;
using Essensoft.AspNetCore.Payment.LianLianPay.Domain;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.LianLianPay.Response
{
    /// <summary>
    /// 用户签约银行卡列表查询
    /// </summary>
    public class LianLianPayQueryBankCardBindListResponse : LianLianPayResponse
    {
        /// <summary>
        /// 请求结果代码 
        /// </summary>
        [JsonProperty("ret_code")]
        public string RetCode { get; set; }

        /// <summary>
        /// 请求结果描述
        /// </summary>
        [JsonProperty("ret_msg")]
        public string RetMsg { get; set; }

        /// <summary>
        /// 签名方式
        /// </summary>
        [JsonProperty("sign_type")]
        public string SignType { get; set; }

        /// <summary>
        /// 签名
        /// </summary>
        [JsonProperty("sign")]
        public string Sign { get; set; }

        /// <summary>
        /// 用户编号。
        /// 商户系统内对用户的唯一编码，可以为自定义字符串，加密密文或者邮箱等可以唯一定义用户的标识。
        /// </summary>
        [JsonProperty("user_id")]
        public string UserId { get; set; }

        /// <summary>
        /// 本次查询返回的总记录条数。
        /// </summary>
        [JsonProperty("count")]
        public string Count { get; set; }

        /// <summary>
        /// 协议号结果集。按照签约时间倒序排列，该参数不参与签名。
        /// </summary>
        [JsonProperty("agreement_list", ItemIsReference = true)]
        public List<Agreement> AgreementList { get; set; }
    }
}
