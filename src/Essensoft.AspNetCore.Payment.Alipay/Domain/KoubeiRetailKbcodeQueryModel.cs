using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KoubeiRetailKbcodeQueryModel Data Structure.
    /// </summary>
    public class KoubeiRetailKbcodeQueryModel : AlipayObject
    {
        /// <summary>
        /// 创建码接口返回的批次id，如果不填写则查询这个带运营商户下所有开放接口生成的码
        /// </summary>
        [JsonPropertyName("batch_id")]
        public string BatchId { get; set; }

        /// <summary>
        /// 当前页码（大于0的整数），默认为1
        /// </summary>
        [JsonPropertyName("page_num")]
        public long PageNum { get; set; }

        /// <summary>
        /// 每页返回的记录数（1~100的整数），默认为10
        /// </summary>
        [JsonPropertyName("page_size")]
        public long PageSize { get; set; }
    }
}
