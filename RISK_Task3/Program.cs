using RISK_Task3.Classes;
using RISK_Task3.Managers;

while (true)
{
    Console.WriteLine("REPORTS");

    CsvManager csvManager = new CsvManager();
    PdfManager pdfManager = new PdfManager();
    ExcelManager excelManager = new ExcelManager();


start:
    Console.WriteLine("You can do this type of operations:");
    Console.WriteLine("1.Add Report");
    Console.WriteLine("2.Delete Report");
    Console.WriteLine("3.Update Report");
    Console.WriteLine("4.Get All Report");
    Console.Write("Enter Operation: ");
    int operation = Convert.ToInt32(Console.ReadLine());

    switch (operation)
    {
        case 1:
            Console.WriteLine("Add operation");
            Console.WriteLine("1.Add Csv");
            Console.WriteLine("2.Add Pdf");
            Console.WriteLine("3.Add Excel");
            Console.Write("Enter Choice: ");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Console.WriteLine("Csv Add Operation");
                    int addCsvId = csvManager.GetAll().Count();
                    Console.Write("Please Enter Csv Text: ");
                    string addedCsvText = Console.ReadLine();
                    Console.WriteLine($"Id: {addCsvId + 1} report: {addedCsvText}  - csv adding...");
                    Csv newCsv = new Csv { Id = addCsvId + 1, TextOfReport = addedCsvText };
                    csvManager.Add(newCsv);
                    break;


                case 2:
                    Console.WriteLine("Pdf Add Operation");
                    int addPdfId = pdfManager.GetAll().Count();
                    Console.Write("Please Enter Pdf Text: ");
                    string addedPdfText = Console.ReadLine();
                    Console.WriteLine($"Id: {addPdfId + 1} report: {addedPdfText}  - pdf adding...");
                    Pdf newPdf = new Pdf { Id = addPdfId + 1, TextOfReport = addedPdfText };
                    pdfManager.Add(newPdf);
                    break;

                case 3:
                    Console.WriteLine("Excel Add Operation");
                    int addExcelId = excelManager.GetAll().Count();
                    Console.Write("Please Enter Excel Text: ");
                    string addedExcelText = Console.ReadLine();
                    Console.WriteLine($"Id: {addExcelId + 1} report: {addedExcelText}  - excel adding...");
                    Excel newExcel = new Excel { Id = addExcelId + 1, TextOfReport = addedExcelText };
                    excelManager.Add(newExcel);
                    break;
                default:
                    Console.WriteLine("There is no such option!");
                    break;


            }

            Console.WriteLine("Do you want to continue? ");
            string answer = Console.ReadLine().ToLower();
            if (answer == "yes")
            {
                goto start;
            }
            else
            {
                break;
            }


        case 2:


            Console.WriteLine("Delete operation");
            Console.WriteLine("1.Delete Csv");
            Console.WriteLine("2.Delete Pdf");
            Console.WriteLine("3.Delete Excel");
            Console.Write("Enter Choice: ");


            int deleteChoice = Convert.ToInt32(Console.ReadLine());

            switch (deleteChoice)
            {
                case 1:
                    Console.Write("Please select the csv file you want to delete: ");
                    int deletedCsvId = Convert.ToInt32(Console.ReadLine());
                    csvManager.Delete(deletedCsvId);

                    break;

                case 2:
                    Console.Write("Please select the pdf file you want to delete: ");
                    int deletedPdfId = Convert.ToInt32(Console.ReadLine());
                    pdfManager.Delete(deletedPdfId);

                    break;

                case 3:


                    Console.Write("Please select the excel file you want to delete: ");
                    int deletedExcelId = Convert.ToInt32(Console.ReadLine());
                    excelManager.Delete(deletedExcelId);

                    break;

                default:
                    Console.WriteLine("There is no such option!");
                    break;

            }

            Console.WriteLine("Do you want to continue? ");
            string secondAnswer = Console.ReadLine().ToLower();
            if (secondAnswer == "yes")
            {
                goto start;
            }
            else
            {
                break;
            }

        case 3:
            Console.WriteLine("Update operation");
            Console.WriteLine("1.Csv update");
            Console.WriteLine("2.Pdf update");
            Console.WriteLine("3.Excel update");
            Console.Write("Enter Choice: ");


            int updateChoice = Convert.ToInt32(Console.ReadLine());
            switch (updateChoice)
            {
                case 1:

                    Console.Write("Please select the csv file you want to update: ");
                    int updatedCsvId = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Please enter new csv text: ");
                    string updatedCsvText = Console.ReadLine();
                    
                    csvManager.Update(updatedCsvId, new Csv { Id = updatedCsvId, TextOfReport = updatedCsvText });
                    break;

                case 2:

                    Console.Write("Please select the pdf file you want to update: ");
                    int updatedPdfId = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Please enter new pdf text: ");
                    string updatedPdfText = Console.ReadLine();

                    pdfManager.Update(updatedPdfId, new Pdf {Id = updatedPdfId, TextOfReport = updatedPdfText });
                    break;

                case 3:
                    Console.Write("Please select the excel file you want to update: ");
                    int updatedExcelId = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Please enter new excel text: ");
                    string updatedExcelText = Console.ReadLine();

                    excelManager.Update(updatedExcelId, new Excel { Id = updatedExcelId, TextOfReport = updatedExcelText });
                    break;
                

                default:
                    Console.WriteLine("There is no such option!");
                    break;

            }
            Console.WriteLine("Do you want to continue? ");
            string thirdAnswer = Console.ReadLine().ToLower();
            if (thirdAnswer == "yes")
            {
                goto start;
            }
            else
            {
                break;
            }

        case 4:
            Console.WriteLine("Get operation");
            Console.WriteLine("1.Get Csv");
            Console.WriteLine("2.Get Pdf");
            Console.WriteLine("3.Get Excel");
            Console.Write("Enter Choice: ");



            int getAllChoice = Convert.ToInt32(Console.ReadLine());
            switch (getAllChoice)
            {
                case 1:
                    Console.WriteLine("Csv files:");
                    foreach (var item in csvManager.GetAll())
                    {
                        Console.WriteLine($"{item.Id} {item.TextOfReport} {item.TypeOfReport}");
                    }
                    break;

                case 2:
                    Console.WriteLine("Pdfs:");
                    foreach (var item in pdfManager.GetAll())
                    {
                        Console.WriteLine($"{item.Id} {item.TextOfReport} {item.TypeOfReport}");
                    }
                    break;
                case 3:
                    Console.WriteLine("Excels:");
                    foreach (var item in excelManager.GetAll())
                    {
                        Console.WriteLine($"{item.Id} {item.TextOfReport} {item.TypeOfReport}");
                    }
                    break;
                default:
                    Console.WriteLine("There is no such option!");
                    break;
            }
            Console.WriteLine("Do you want to continue? ");
            string fourthAnswer = Console.ReadLine().ToLower();
            if (fourthAnswer == "yes")
            {
                goto start;
            }
            else
            {
                break;
            }

    }

    break;

}

