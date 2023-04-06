﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SupplementShop.Models;
using System.Web.ModelBinding;


namespace SupplementShop
{
    public partial class ProductDetails : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public IQueryable<Product> GetProduct([QueryString("productID")] int? productId)
        {
            var _db = new SupplementShop.Models.ProductContext();
            IQueryable<Product> query = _db.Products;

            query = productId.HasValue && productId > 0
                ? query.Where(p => p.ProductID == productId)
                : null;

            return query;
        }
    }
}