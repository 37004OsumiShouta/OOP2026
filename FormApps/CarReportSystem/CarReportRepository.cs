using CarReportSystem;
using Microsoft.Data.Sqlite;
using System.Data;
using System.Diagnostics;
using System.Diagnostics.Metrics;
using System.Globalization;
using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace SQLiteProductSample;

// Productsテーブルに対するDB操作をまとめたクラス
// CRUD（Create / Read / Update / Delete）を担当する
public class CarReportRepository {
    // 全商品を取得する。Read（SELECT）に相当する
    public static List<CarReport> GetAll() {

        var carReports = new List<CarReport>();


        using var connection = Database.GetConnection();
        connection.Open();

        // SQLを実行するためのコマンドオブジェクトを作る
        using var command = connection.CreateCommand();

        // Productsテーブルを作るSQL
        command.CommandText =
            """
            SELECT Id, Data, Autor, Maker, CarName, Report, Picture
            FROM CarReports
            ORDER BY Id;
            """;

        // SELECTを実行し、複数行の検索結果を読み取る
        using var reader = command.ExecuteReader();

        while (reader.Read()) {
            carReports.Add(new CarReport {
                Id = reader.GetInt32(0),
                Date = DateTime.ParseExact(
                    reader.GetString(1),
                "yyyy-MM-dd",
                CultureInfo.InvariantCulture),
                Author = reader.GetString(2),
                Maker = (CarReport.MakerGroup)reader.GetInt32(3),
                CarName = reader.GetString(4),
                Report = reader.GetString(5),
                Picture = reader.IsDBNull(6)
                ? null: BytesToImage(reader.GetFieldValue<byte[]>(6))
            });
        }
        return carReports;

    }
    //商品を1件追加する。Create(INSERT)に相当する
    //戻り値として自動採番されたIdを返す
    public int Add(DateTime date, string autor,DateTime maker, string carName,string report,  Image picture) {
        //接続オブジェクトを生成する。
        using var connection = Database.GetConnection();

        //DBを開く
        connection.Open();

        //SQLを実行するためのコマンドオブジェクトを作る
        using var command = connection.CreateCommand();


        command.CommandText =
            """
            
            INSERT INTO CarReports

            (Date, Author, Maker, CarName, Report, Picture)

            VALUES

            ($date, $author, $maker, $carName, $report, $picture);

            SELECT last_insert_rowid ();
                        
            
            """;
        command.Parameters.AddWithValue("$date", date);
        command.Parameters.AddWithValue("$autor", autor);
        command.Parameters.AddWithValue("$maker", maker);
        command.Parameters.AddWithValue("$carName", carName);
        command.Parameters.AddWithValue("$report", report);
        command.Parameters.AddWithValue("$picture", picture);
        //一つの値を返すSQLを実行する
        var result = command.ExecuteScalar();

        if (result is null)
            throw new InvalidOperationException("登録した商品のIDを取得できませんでした。");

        //SQLiteのINTEGERはlongとして返るため、intへ変換する
        return Convert.ToInt32((long)result);
    }

    public void Update(CarReport carReport) {
        //接続オブジェクトを生成する。
        using var connection = Database.GetConnection();

        //DBを開く
        connection.Open();

        //SQLを実行するためのコマンドオブジェクトを作る
        using var command = connection.CreateCommand();


        command.CommandText =
            """
            UPDATE CarReports
            SET Date = $date, Author = $author, Maker = $maker,
            CarName = $carName, Report = $report, Picture = $picture
            WHERE Id = $id;
            """;
        command.Parameters.AddWithValue("$data", carReport.Date);
        command.Parameters.AddWithValue("$autor", carReport.Author);
        command.Parameters.AddWithValue("maker", carReport.Maker);
        command.Parameters.AddWithValue("carName", carReport.CarName);
        command.Parameters.AddWithValue("report", carReport.Report);
        command.Parameters.AddWithValue("picture", carReport.Picture);

        if (command.ExecuteNonQuery() == 0)
            throw new InvalidOperationException("修正対象の商品が見つかりませんでした。");
    }
    public void Delete(CarReport carReport) {
        using var connection = Database.GetConnection();

        connection.Open();

        using var command = connection.CreateCommand();

        command.CommandText =
            """
            DELETE FROM CarReports
            WHERE Id = $id;
            """;
        command.Parameters.AddWithValue("$id", carReport.Id);
        

        if (command.ExecuteNonQuery() == 0)
            throw new InvalidOperationException("削除対象の商品が見つかりませんでした。");
    }
    private static byte[] ImageToBytes(Image? image) {
        if (image is null) return null;

        using var stream = new MemoryStream();
        image.Save(stream, image.RawFormat);
        return stream.ToArray();
    }

    private static Image BytesToImage(byte[] data) {
        using var stream = new MemoryStream(data);
        using var image = Image.FromStream(stream);
        // MemoryStream破棄後も利用できるようBitmapとしてコピーする。
        return new Bitmap(image);
    }
}
