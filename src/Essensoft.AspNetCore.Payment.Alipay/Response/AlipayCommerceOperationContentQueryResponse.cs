using System.Collections.Generic;
using System.Text.Json.Serialization;
using Essensoft.AspNetCore.Payment.Alipay.Domain;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayCommerceOperationContentQueryResponse.
    /// </summary>
    public class AlipayCommerceOperationContentQueryResponse : AlipayResponse
    {
        /// <summary>
        /// 内容信息列表 , json 格式 , 每一个展台对应一个 内容列表 .  每一个内容信息模型对应 : ContentInfoModel
        /// </summary>
        [JsonPropertyName("content_infos")]
        public List<BoothContentInfoModel> ContentInfos { get; set; }

        /// <summary>
        /// 非单条内容信息维度的扩展数据
        /// </summary>
        [JsonPropertyName("ext_data")]
        public OperationExtDataModel ExtData { get; set; }
    }
}
