using Newtonsoft.Json;
using Essensoft.AspNetCore.Alipay.Domain;

namespace Essensoft.AspNetCore.Alipay.Response
{
    /// <summary>
    /// ZhimaCreditPeLawsuitRecordGetResponse.
    /// </summary>
    public class ZhimaCreditPeLawsuitRecordGetResponse : AlipayResponse
    {
        /// <summary>
        /// 芝麻信用对于每一次请求返回的业务号。后续可以通过此业务号进行对账
        /// </summary>
        [JsonProperty("biz_no")]
        public string BizNo { get; set; }

        /// <summary>
        /// 个人涉诉记录
        /// </summary>
        [JsonProperty("lawsuit_person_record")]
        public LawsuitPersonRecord LawsuitPersonRecord { get; set; }
    }
}
