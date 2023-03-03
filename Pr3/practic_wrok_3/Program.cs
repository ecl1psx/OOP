using practic_wrok_3;

class Program
{
    public static void Main()
    {
        var csvAnalyzer = new CsvAnalyzer( Path.Combine(Environment.CurrentDirectory, $"data.csv"));
        var dictionary = csvAnalyzer.AggregateByDate();
        csvAnalyzer.Records = CsvFileRecord.From(dictionary);
        
        csvAnalyzer.Save();;

        var productsList = new ProductList("/home/ecl1psx/products");
        var products = productsList.GetProductsForDate(DateTime.Now);

        foreach (var product in products)
        {
            ProductList.PrintProduct(product);
        }

        var imageEditor = new ImageEditor("/home/ecl1psx/test.jpg");
        imageEditor.Reverse();
        imageEditor.ApplyChanges();

        var textStatistics = new TextFileStatistics("/home/ecl1psx/test2");
        var report = textStatistics.CollectStatistic();
        textStatistics.SaveReport("/home/ecl1psx/test2/report.txt", report);
    }
}