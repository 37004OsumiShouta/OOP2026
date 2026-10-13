using Microsoft.EntityFrameworkCore;
using SelfOrderSystem.Models;


namespace SelfOrderSystem.Data {
    public class AppDbContext : DbContext {

        //Program.cs で登録した接続設定を受け取る
        public AppDbContext(DbContextOptions<AppDbContext> options)
       : base(options) {    //受け取った設定を親クラスに返す
        }

        //Categories　テーブルをCategory 型として問い合わせるためのプロパティ
        public DbSet<Category> Categories => Set<Category>();        // カテゴリ 

        //Products テーブルを Product 型として問い合わせるためのプロパティ
        public DbSet<Product> Products => Set<Product>();            // 商品 
    }
}

