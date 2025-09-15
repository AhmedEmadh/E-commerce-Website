using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using System.ComponentModel;

namespace AdminPanel.ECommerceWebsite;

[ConnectionKey("E-commerce-Website"), Module("ECommerceWebsite"), TableName("Categories")]
[DisplayName("Categories"), InstanceName("Categories")]
[ReadPermission("Categories")]
[ModifyPermission("Categories")]
[ServiceLookupPermission("Categories")]
public sealed class CategoriesRow : Row<CategoriesRow.RowFields>, IIdRow, INameRow
{
    [DisplayName("Id"), Identity, IdProperty]
    public int? Id { get => fields.Id[this]; set => fields.Id[this] = value; }

    [DisplayName("Name"), NotNull, QuickSearch, NameProperty]
    public string Name { get => fields.Name[this]; set => fields.Name[this] = value; }

    [DisplayName("Description")]
    public string Description { get => fields.Description[this]; set => fields.Description[this] = value; }

    [DisplayName("Photo")]
    public string Photo { get => fields.Photo[this]; set => fields.Photo[this] = value; }

    public class RowFields : RowFieldsBase
    {
        public Int32Field Id;
        public StringField Name;
        public StringField Description;
        public StringField Photo;

    }
}