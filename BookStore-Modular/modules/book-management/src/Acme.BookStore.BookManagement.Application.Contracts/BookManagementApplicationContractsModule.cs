﻿using Volo.Abp.Application;
using Volo.Abp.Modularity;
using Volo.Abp.VirtualFileSystem;

namespace Acme.BookStore.BookManagement
{
    [DependsOn(
        typeof(BookManagementDomainSharedModule),
        typeof(AbpDddApplicationModule)
        )]
    public class BookManagementApplicationContractsModule : AbpModule
    {
    }
}
