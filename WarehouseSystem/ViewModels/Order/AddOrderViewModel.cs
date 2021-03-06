﻿using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WarehouseSystem.DTO;
using WarehouseSystem.Service;

namespace WarehouseSystem.ViewModels
{
    public class AddOrderViewModel : Screen
    {
        public string OrderItem { get; set; }

        public int ItemQuantity { get; set; }

        public string RecipientCompany { get; set; }

        public string CityTown { get; set; }

        public string PostalCode1 { get; set; }

        public string PostalCode2 { get; set; }

        public string StreetAddress { get; set; }

        public float Weight { get; set; }

        public string Description { get; set; }

        public AddOrderViewModel()
        {
        }

        public void Add()
        {
            var newOrder = new OrderDTO();
            newOrder.OrderItem = OrderItem;
            newOrder.ItemQuantity = ItemQuantity;
            newOrder.RecipientCompany = RecipientCompany;
            newOrder.CityTown = CityTown;
            newOrder.PostalCode = string.Format("{0}-{1}", PostalCode1, PostalCode2);
            newOrder.StreetAddress = StreetAddress;
            newOrder.Weight = Weight;
            newOrder.Description = Description;
            OrderService.Add(newOrder);
            TryClose();
        }

        public void Close()
        {
            TryClose();
        }
    }
}