using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using System.ComponentModel;

namespace AdminPanel.ECommerceWebsite;

[ConnectionKey("E-commerce-Website"), Module("ECommerceWebsite"), TableName("Carts")]
[DisplayName("Carts"), InstanceName("Carts")]
[ReadPermission("Carts")]
[ModifyPermission("Carts")]
[ServiceLookupPermission("Carts")]
public sealed class CartsRow : Row<CartsRow.RowFields>, IIdRow, INameRow
{
    const string jProduct = nameof(jProduct);

    [DisplayName("Id"), PrimaryKey, NotNull, IdProperty]
    public int? Id { get => fields.Id[this]; set => fields.Id[this] = value; }

    [DisplayName("User Id"), NotNull, QuickSearch, NameProperty]
    public string UserId { get => fields.UserId[this]; set => fields.UserId[this] = value; }

    [DisplayName("Product"), NotNull, ForeignKey(typeof(ProductsRow)), LeftJoin(jProduct), TextualField(nameof(ProductName))]
    [ServiceLookupEditor(typeof(ProductsRow))]
    public int? ProductId { get => fields.ProductId[this]; set => fields.ProductId[this] = value; }

    [DisplayName("Quantity"), NotNull]
    public int? Quantity { get => fields.Quantity[this]; set => fields.Quantity[this] = value; }

    [DisplayName("Product Name"), Origin(jProduct, nameof(ProductsRow.Name))]
    public string ProductName { get => fields.ProductName[this]; set => fields.ProductName[this] = value; }

    public class RowFields : RowFieldsBase
    {
        public Int32Field Id;
        public StringField UserId;
        public Int32Field ProductId;
        public Int32Field Quantity;

        public StringField ProductName;
    }
}