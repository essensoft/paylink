using System;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// AlipaySocialGiftStockUploadModel Data Structure.
    /// </summary>
    [Serializable]
    public class AlipaySocialGiftStockUploadModel : AlipayObject
    {
        /// <summary>
        /// 券码列表，商户体系内可兑换使用的券码(大小写不敏感)。注意数量必须大于0，同时系统会默认trim处理。库存导入接口，主要就是导入这些卡码。对于同一批次的幂等。卡码不会重复导入。
        /// </summary>
        [JsonProperty("entity_list")]
        public List<string> EntityList { get; set; }

        /// <summary>
        /// 幂等号，请保持唯一, 如果重复则认为重复请求, 可以使用uuid生成或使用商户自己的单据号
        /// </summary>
        [JsonProperty("idempotent_no")]
        public string IdempotentNo { get; set; }

        /// <summary>
        /// 商户再送礼平台的唯一ID，用于标识具体的调用业务方，需要先在送礼平台进行业务类型的分配之后才看使用。
        /// </summary>
        [JsonProperty("mid")]
        public string Mid { get; set; }

        /// <summary>
        /// 对应送礼平台skuId，库存导入必须指定唯一的一个SKUID，该id需要送礼平台方先创建相应产品后，在通知使用方
        /// </summary>
        [JsonProperty("sku_id")]
        public string SkuId { get; set; }
    }
}
