using Essensoft.AspNetCore.Payment.LianLianPay.Domain;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace Essensoft.AspNetCore.Payment.LianLianPay.Response
{
    public class LianLianPayQueryBankCarBindListResponse : LianLianPayResponse
    {
        /// <summary>
        /// 交易结果代码 
        /// </summary>
        [JsonProperty("ret_code")]
        public string RetCode { get; set; }

        /// <summary>
        /// 交易结果描述
        /// </summary>
        [JsonProperty("ret_msg")]
        public string RetMsg { get; set; }

        /// <summary>
        /// 商户用户唯一编号
        /// 该用户在商户系统中的唯一编号，要求是该 编号在商户系统中唯一标识该用户
        /// </summary>
        [JsonProperty("user_id")]
        public string UserId { get; set; }

        /// <summary>
        /// 总记录条数
        /// 本次返回的总记录条数 
        /// </summary>
        [JsonProperty("count")]
        public string Count { get; set; }

        /// <summary>
        /// 结果集
        /// 返回按签约时间倒叙的结果集
        /// </summary>
        [JsonProperty("agreement_list", ItemIsReference = true)]
        public List<Agreement> AgreementList { get; set; }

        /// <summary>
        /// 签名方式
        /// </summary>
        [JsonProperty("sign_type")]
        public string SignType { get; set; }

        /// <summary>
        /// 签名
        /// RSA加密签名，见安全签名机制 
        /// </summary>
        [JsonProperty("sign")]
        public string Sign { get; set; }
    }
}
