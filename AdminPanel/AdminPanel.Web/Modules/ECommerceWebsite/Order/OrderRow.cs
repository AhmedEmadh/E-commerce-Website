using Serenity.ComponentModel;
using Serenity.Data;
using Serenity.Data.Mapping;
using System;
using System.ComponentModel;

namespace AdminPanel.ECommerceWebsite;

[ConnectionKey("E-commerce-Website"), Module("ECommerceWebsite"), TableName("Order")]
[DisplayName("Order"), InstanceName("Order")]
[ReadPermission("Order")]
[ModifyPermission("Order")]
[ServiceLookupPermission("Order")]
public sealed class OrderRow : Row<OrderRow.RowFields>, IIdRow, INameRow
{
    [DisplayName("Id"), Column("id"), Identity, IdProperty]
    public int? Id { get => fields.Id[this]; set => fields.Id[this] = value; }

    [DisplayName("Name"), QuickSearch, NameProperty]
    public string Name { get => fields.Name[this]; set => fields.Name[this] = value; }

    [DisplayName("Address")]
    public string Address { get => fields.Address[this]; set => fields.Address[this] = value; }

    [DisplayName("Email")]
    public string Email { get => fields.Email[this]; set => fields.Email[this] = value; }

    [DisplayName("Phone")]
    public string Phone { get => fields.Phone[this]; set => fields.Phone[this] = value; }

    [DisplayName("User Id"), NotNull]
    public string UserId { get => fields.UserId[this]; set => fields.UserId[this] = value; }

    [DisplayName("Date Added")]
    public DateTime? DateAdded { get => fields.DateAdded[this]; set => fields.DateAdded[this] = value; }

    [DisplayName("Total Price"), Size(18), Scale(2)]
    public decimal? TotalPrice { get => fields.TotalPrice[this]; set => fields.TotalPrice[this] = value; }

    [DisplayName("Status")]
    public int? Status { get => fields.Status[this]; set => fields.Status[this] = value; }

    public class RowFields : RowFieldsBase
    {
        public Int32Field Id;
        public StringField Name;
        public StringField Address;
        public StringField Email;
        public StringField Phone;
        public StringField UserId;
        public DateTimeField DateAdded;
        public DecimalField TotalPrice;
        public Int32Field Status;

    }
}