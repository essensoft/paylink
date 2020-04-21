using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Response
{
    /// <summary>
    /// AlipayDataDataserviceYuebaoassetDetailSendResponse.
    /// </summary>
    public class AlipayDataDataserviceYuebaoassetDetailSendResponse : AlipayResponse
    {
        /// <summary>
        /// yeb_asset_data_num:本次录入数据条数。  可以根据该字段获取本次录入的数据条数，判断是否所有数据都已经落地。
        /// </summary>
        [JsonPropertyName("yeb_asset_data_num")]
        public long YebAssetDataNum { get; set; }
    }
}
