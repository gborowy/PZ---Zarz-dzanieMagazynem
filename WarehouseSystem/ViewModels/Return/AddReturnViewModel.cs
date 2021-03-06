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
    public class AddReturnViewModel : Screen
    {
        private bool IsEdit { get; set; }
        private ReturnDTO toEdit { get; set; }
        public DateTime DateOfAddition { get; set; } = DateTime.Now;
        public string Client { get; set; }
        public string Description { get; set; }
        public string Attachment { get; set; }
        public string ButtonLabel { get; set; }

        public void AddAttachment()
        {
        }

        public AddReturnViewModel(ReturnDTO ret)
        {
            IsEdit = true;
            ButtonLabel = "Edit";
            this.toEdit = ret;
            DateOfAddition = ret.Date;
            Client = ret.Client;
            Description = ret.Description;
            Attachment = ret.Attachment;
            NotifyOfPropertyChange(() => DateOfAddition);
            NotifyOfPropertyChange(() => Client);
            NotifyOfPropertyChange(() => Description);
            NotifyOfPropertyChange(() => Attachment);
        }

        public AddReturnViewModel()
        {
            IsEdit = false;
            ButtonLabel = "Add";
        }

        public void Add()
        {
            var newReturn = new ReturnDTO();
            newReturn.Date = DateOfAddition;
            newReturn.Client = Client;
            newReturn.Description = Description;
            newReturn.Attachment = Attachment;
            ReturnService.Add(newReturn);
            Close();
        }

        public void Close()
        {
            TryClose();
        }
    }
}