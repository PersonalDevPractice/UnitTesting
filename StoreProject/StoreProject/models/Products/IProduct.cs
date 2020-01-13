using System;
using System.Collections.Generic;
using System.Text;

namespace StoreProject.models
{
    public interface IProduct
    {
        string name { get; set; }
        string price { get; set; }
        string category { get; set; }
    }
}
