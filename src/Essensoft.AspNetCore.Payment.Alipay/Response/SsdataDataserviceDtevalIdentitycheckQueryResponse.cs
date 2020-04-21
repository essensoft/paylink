using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// SsdataDataserviceDtevalIdentitycheckQueryResponse.
    /// </summary>
    public class SsdataDataserviceDtevalIdentitycheckQueryResponse : AlipayResponse
    {
        /// <summary>
        /// evidence：关联人的手机号是否和该用户通话以及通话次数
        /// </summary>
        [JsonPropertyName("evidence")]
        public string Evidence { get; set; }

        /// <summary>
        /// ext_map:额外参数，预留
        /// </summary>
        [JsonPropertyName("ext_map")]
        public string ExtMap { get; set; }

        /// <summary>
        /// id_card_no_match_flag:身份证号匹配结果标识，表示传入的身份证号是否匹配，含四种状态：完全匹配成功（MATCHSUCCESS），模糊匹配成功（FUZZYMATCHSUCCESS），匹配失败（MATCHFAIL），无数据（NODATA）
        /// </summary>
        [JsonPropertyName("id_card_no_match_flag")]
        public string IdCardNoMatchFlag { get; set; }

        /// <summary>
        /// name_match_flag:姓名匹配标识，表示传入的姓名是否匹配，含四种状态：完全匹配成功（MATCHSUCCESS），模糊匹配成功（FUZZYMATCHSUCCESS），匹配失败（MATCHFAIL），无数据（NODATA）
        /// </summary>
        [JsonPropertyName("name_match_flag")]
        public string NameMatchFlag { get; set; }

        /// <summary>
        /// push_ant_data_flag:是否推送蚂蚁数据标志,推送成功返回true，失败返回false
        /// </summary>
        [JsonPropertyName("push_ant_data_flag")]
        public string PushAntDataFlag { get; set; }
    }
}
