using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace Essensoft.AspNetCore.Payment.Alipay.Domain
{
    /// <summary>
    /// KoubeiItemModifyModel Data Structure.
    /// </summary>
    public class KoubeiItemModifyModel : AlipayObject
    {
        /// <summary>
        /// 服务商、服务商员工、商户、商户员工等口碑角色操作时必填，对应为《koubei.member.data.oauth.query》中的auth_code，有效期24小时；
        /// </summary>
        [JsonPropertyName("auth_code")]
        public string AuthCode { get; set; }

        /// <summary>
        /// 口碑商品所属的后台类目id，ISV可通过开放接口koubei.item.category.children.batchquery来获得后台类目树，并选择叶子类目，作为该值传入
        /// </summary>
        [JsonPropertyName("category_id")]
        public string CategoryId { get; set; }

        /// <summary>
        /// 商品首图。支持bmp,png,jpeg,jpg,gif格式的图片，建议宽高比16:9，建议宽高：1242*698px 图片大小≤5M。图片大小超过5M,接口会报错。若图片尺寸不对，口碑服务器自身不会做压缩，但是口碑把这些图片放到客户端上展现时，自己会做性能优化(等比缩放，以图片中心为基准裁剪)。
        /// </summary>
        [JsonPropertyName("cover")]
        public string Cover { get; set; }

        /// <summary>
        /// 商品描述，列表类型，每一项的key，value的描述见下面两行
        /// </summary>
        [JsonPropertyName("descriptions")]
        public List<KoubeiItemDescription> Descriptions { get; set; }

        /// <summary>
        /// 售卖结束时间。当到达该时间时，商品暂停售卖，将不在客户端中继续展示，用户无法继续购买。  注意：该时间不能晚于核销绝对有效期的结束时间。
        /// </summary>
        [JsonPropertyName("gmt_end")]
        public string GmtEnd { get; set; }

        /// <summary>
        /// 商品售卖开始时间，商品状态有效并且到达生效时间后才可在客户端（消费者端）展示出来，如果商品生效时间小于当前时间，则立即生效。  说明： 商品的生效时间不能早于创建当天的0点
        /// </summary>
        [JsonPropertyName("gmt_start")]
        public string GmtStart { get; set; }

        /// <summary>
        /// 商品库存数量，标准商品必填，非标准商品，不需要填写
        /// </summary>
        [JsonPropertyName("inventory")]
        public long Inventory { get; set; }

        /// <summary>
        /// 非标准商品详情页url，用户通过此url跳转到非标准商品的商品详情页，非标准商品必填
        /// </summary>
        [JsonPropertyName("item_detail_url")]
        public string ItemDetailUrl { get; set; }

        /// <summary>
        /// 口碑体系内部商品的唯一标识，后续的增删改查接口都使用该ID作为主键
        /// </summary>
        [JsonPropertyName("item_id")]
        public string ItemId { get; set; }

        /// <summary>
        /// 备注
        /// </summary>
        [JsonPropertyName("memo")]
        public string Memo { get; set; }

        /// <summary>
        /// 操作上下文。isv角色操作时必填。其他角色不需填写。
        /// </summary>
        [JsonPropertyName("operation_context")]
        public KoubeiOperationContext OperationContext { get; set; }

        /// <summary>
        /// 标准商品为原价，必填。非标准商品请勿填写，填写无效。价格单位为元
        /// </summary>
        [JsonPropertyName("original_price")]
        public string OriginalPrice { get; set; }

        /// <summary>
        /// 商品详情图。尺寸大小与cover一致，最多5张，以英文逗号分隔
        /// </summary>
        [JsonPropertyName("picture_details")]
        public string PictureDetails { get; set; }

        /// <summary>
        /// 标准商品为现价,必填。非标准商品为最小价格（非标商品为xx元起）必填。价格单位为元。如果标准商品现价不填写，则以原价进行售卖；如果现价与原价相等时，则会以原价售卖，并且客户端只展示一个价格（原价）
        /// </summary>
        [JsonPropertyName("price")]
        public string Price { get; set; }

        /// <summary>
        /// 支持英文字母和数字，由开发者自行定义（不允许重复），在商品notify消息中也会带有该参数，以此标明本次notify消息是对哪个请求的回应
        /// </summary>
        [JsonPropertyName("request_id")]
        public string RequestId { get; set; }

        /// <summary>
        /// 上架门店id列表，即传入一个或多个shop_id。多个ID则以英文分隔
        /// </summary>
        [JsonPropertyName("shop_ids")]
        public string ShopIds { get; set; }

        /// <summary>
        /// 商品名称，请勿超过40汉字，80个字符
        /// </summary>
        [JsonPropertyName("subject")]
        public string Subject { get; set; }

        /// <summary>
        /// 商品1:1首图，该封面图将展示在淘抢购、聚划算等商品售卖渠道。支持bmp、png、jpeg、jpg、gif格式，建议宽高比1:1，建议宽高1500*1500px，图片大小≤5M。图片大小超过5M，接口会报错。若图片尺寸不符，口碑服务器自身不会做压缩，但在口碑客户端展现时，会自动做性能优化（等比缩放，以图片中心为基准裁剪）。
        /// </summary>
        [JsonPropertyName("tb_cover")]
        public string TbCover { get; set; }

        /// <summary>
        /// 交易凭证类商品模板信息
        /// </summary>
        [JsonPropertyName("trade_voucher_item_template")]
        public KoubeiTradeVoucherItemTemplete TradeVoucherItemTemplate { get; set; }

        /// <summary>
        /// 商品顺序权重，必须是整数，不传默认为0，权重数值越大排序越靠前
        /// </summary>
        [JsonPropertyName("weight")]
        public string Weight { get; set; }
    }
}
