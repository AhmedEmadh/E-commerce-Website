using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using System;
using System.ComponentModel;

namespace AdminPanel.ECommerceWebsite;

[ConnectionKey("E-commerce-Website"), Module("ECommerceWebsite"), TableName("Products")]
[DisplayName("Products"), InstanceName("Products")]
[ReadPermission("Products")]
[ModifyPermission("Products")]
[ServiceLookupPermission("Products")]
public sealed class ProductsRow : Row<ProductsRow.RowFields>, IIdRow, INameRow
{
    const string jCategory = nameof(jCategory);

    [DisplayName("Id"), Identity, IdProperty]
    public int? Id { get => fields.Id[this]; set => fields.Id[this] = value; }

    [DisplayName("Name"), NotNull, QuickSearch, NameProperty]
    public string Name { get => fields.Name[this]; set => fields.Name[this] = value; }

    [DisplayName("Description")]
    public string Description { get => fields.Description[this]; set => fields.Description[this] = value; }

    [DisplayName("Price"), Size(18), Scale(2)]
    public decimal? Price { get => fields.Price[this]; set => fields.Price[this] = value; }

    [DisplayName("Category"), ForeignKey(typeof(CategoriesRow)), LeftJoin(jCategory), TextualField(nameof(CategoryName))]
    [ServiceLookupEditor(typeof(CategoriesRow))]
    public int? CategoryId { get => fields.CategoryId[this]; set => fields.CategoryId[this] = value; }

    [DisplayName("Photo")]
    public string Photo { get => fields.Photo[this]; set => fields.Photo[this] = value; }

    [DisplayName("Date Added")]
    public DateTime? DateAdded { get => fields.DateAdded[this]; set => fields.DateAdded[this] = value; }

    [DisplayName("Quantity")]
    public int? Quantity { get => fields.Quantity[this]; set => fields.Quantity[this] = value; }

    [DisplayName("Category Name"), Origin(jCategory, nameof(CategoriesRow.Name))]
    public string CategoryName { get => fields.CategoryName[this]; set => fields.CategoryName[this] = value; }

    public class RowFields : RowFieldsBase
    {
        public Int32Field Id;
        public StringField Name;
        public StringField Description;
        public DecimalField Price;
        public Int32Field CategoryId;
        public StringField Photo;
        public DateTimeField DateAdded;
        public Int32Field Quantity;

        public StringField CategoryName;
    }
}