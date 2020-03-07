using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayOpenMiniCloudDetailQueryResponse.
    /// </summary>
    public class AlipayOpenMiniCloudDetailQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 用户金融云展示的小程序信息列表
        /// </summary>
        [JsonPropertyName("miniapp_cloud_detail_info_list")]
        public List<MiniappCloudDetailInfo> MiniappCloudDetailInfoList { get; set; }

        /// <summary>
        /// partner_id，如果只传入了APPID，返回该appid的pid
        /// </summary>
        [JsonPropertyName("partner_id")]
        public string PartnerId { get; set; }
    }
}
