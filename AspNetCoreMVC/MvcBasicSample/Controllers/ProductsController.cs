using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MvcBasicSample.Data;

namespace MvcBasicSample.Controllers;
public class ProductsController : Controller {
    private readonly AppDbContext _db;

    public ProductsController(AppDbContext db) {
        _db = db;
    }

    //products/index で商品一覧を取得する (非同期メソッド)
    public async Task<IActionResult> Index() {

        //Idの昇順で取得し結果をList<Product>にする
        var products = await _db.Products
            .Where(products => products.Price > 500)
            .OrderBy(product => product.Price)
            .ToListAsync();

        return View(products);
    }
}