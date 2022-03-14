﻿using System;
using System.Linq;
using System.Net.Mime;
using FirstWeb.Domain.Entities;

namespace FirstWeb.Domain.Repositories.Abstract
{
    public interface IServiceItemsRepository
    {
        IQueryable<ServiceItem> GetServiceItems();
        ServiceItem GetServiceItemById(Guid id);
        void SaveServiceItem(ServiceItem entity);
        void DeleteServiceItem(Guid id);
    }
}