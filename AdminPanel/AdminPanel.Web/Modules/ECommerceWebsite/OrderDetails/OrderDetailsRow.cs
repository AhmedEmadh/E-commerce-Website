using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using System.ComponentModel;

namespace AdminPanel.ECommerceWebsite;

[ConnectionKey("E-commerce-Website"), Module("ECommerceWebsite"), TableName("OrderDetails")]
[DisplayName("Order Details"), InstanceName("Order Details")]
[ReadPermission("OrderDetails")]
[ModifyPermission("OrderDetails")]
[ServiceLookupPermission("OrderDetails")]
public sealed class OrderDetailsRow : Row<OrderDetailsRow.RowFields>, IIdRow, INameRow
{
    const string jUser = nameof(jUser);
    const string jProduct = nameof(jProduct);
    const string jOrder = nameof(jOrder);

    [DisplayName("Id"), Identity, IdProperty]
    public int? Id { get => fields.Id[this]; set => fields.Id[this] = value; }

    [DisplayName("User"), Column("UserID"), Size(450), NotNull, ForeignKey("AspNetUsers", "Id"), LeftJoin(jUser), QuickSearch, NameProperty]
    [TextualField(nameof(UserName))]
    public string UserId { get => fields.UserId[this]; set => fields.UserId[this] = value; }

    [DisplayName("Product"), Column("productId"), NotNull, ForeignKey(typeof(ProductsRow)), LeftJoin(jProduct)]
    [TextualField(nameof(ProductName)), ServiceLookupEditor(typeof(ProductsRow), Service = "ECommerceWebsite/Products/List")]
    public int? ProductId { get => fields.ProductId[this]; set => fields.ProductId[this] = value; }

    [DisplayName("Quantity"), NotNull]
    public int? Quantity { get => fields.Quantity[this]; set => fields.Quantity[this] = value; }

    [DisplayName("Order"), NotNull, ForeignKey(typeof(OrderRow)), LeftJoin(jOrder), TextualField(nameof(OrderName))]
    [ServiceLookupEditor(typeof(OrderRow))]
    public int? OrderId { get => fields.OrderId[this]; set => fields.OrderId[this] = value; }

    [DisplayName("Price"), Size(18), Scale(2), NotNull]
    public decimal? Price { get => fields.Price[this]; set => fields.Price[this] = value; }

    [DisplayName("User User Name"), Expression($"{jUser}.[UserName]")]
    public string UserName { get => fields.UserName[this]; set => fields.UserName[this] = value; }

    [DisplayName("Product Name"), Origin(jProduct, nameof(ProductsRow.Name))]
    public string ProductName { get => fields.ProductName[this]; set => fields.ProductName[this] = value; }

    [DisplayName("Order Name"), Origin(jOrder, nameof(OrderRow.Name))]
    public string OrderName { get => fields.OrderName[this]; set => fields.OrderName[this] = value; }

    public class RowFields : RowFieldsBase
    {
        public Int32Field Id;
        public StringField UserId;
        public Int32Field ProductId;
        public Int32Field Quantity;
        public Int32Field OrderId;
        public DecimalField Price;

        public StringField UserName;
        public StringField ProductName;
        public StringField OrderName;
    }
}