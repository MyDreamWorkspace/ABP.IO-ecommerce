﻿using Acme.BookStore.BookManagement.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace Acme.BookStore.BookManagement.Controllers
{
    public abstract class BookManagementController : AbpController
    {
        protected BookManagementController()
        {
            LocalizationResource = typeof(BookManagementResource);
        }
    }
}
