using System;
using System.IO;
using System.Data;
using System.Text;
using FifaLibrary;

namespace DbCli
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length < 3)
            {
                PrintUsage();
                Environment.Exit(1);
            }

            string command = args[0].ToLowerInvariant();
            string dbPath = args[1];
            string xmlPath = args[2];

            if (!File.Exists(dbPath))
            {
                Console.WriteLine($"ERROR: Database file not found: {dbPath}");
                Environment.Exit(1);
            }
            if (!File.Exists(xmlPath))
            {
                Console.WriteLine($"ERROR: Schema XML file not found: {xmlPath}");
                Environment.Exit(1);
            }

            try
            {
                switch (command)
                {
                    case "list-tables":
                        ListTables(dbPath, xmlPath);
                        break;

                    case "table-info":
                        if (args.Length < 4)
                        {
                            Console.WriteLine("Usage: DbCli.exe table-info <db_path> <xml_path> <table_name>");
                            Environment.Exit(1);
                        }
                        TableInfo(dbPath, xmlPath, args[3]);
                        break;

                    case "export-table":
                        if (args.Length < 5)
                        {
                            Console.WriteLine("Usage: DbCli.exe export-table <db_path> <xml_path> <table_name> <output_file>");
                            Environment.Exit(1);
                        }
                        ExportTableCmd(dbPath, xmlPath, args[3], args[4]);
                        break;

                    case "import-table":
                        if (args.Length < 6)
                        {
                            Console.WriteLine("Usage: DbCli.exe import-table <db_path> <xml_path> <table_name> <input_file> <output_db_path>");
                            Environment.Exit(1);
                        }
                        ImportTableCmd(dbPath, xmlPath, args[3], args[4], args[5]);
                        break;

                    case "export-all":
                        if (args.Length < 4)
                        {
                            Console.WriteLine("Usage: DbCli.exe export-all <db_path> <xml_path> <output_dir>");
                            Environment.Exit(1);
                        }
                        ExportAll(dbPath, xmlPath, args[3]);
                        break;

                    case "import-all":
                        if (args.Length < 5)
                        {
                            Console.WriteLine("Usage: DbCli.exe import-all <db_path> <xml_path> <input_dir> <output_db_path>");
                            Environment.Exit(1);
                        }
                        ImportAll(dbPath, xmlPath, args[3], args[4]);
                        break;

                    default:
                        Console.WriteLine($"ERROR: Unknown command: {command}");
                        PrintUsage();
                        Environment.Exit(1);
                        break;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"ERROR: Operation failed: {ex.Message}");
                Console.WriteLine(ex.StackTrace);
                Environment.Exit(1);
            }
        }

        static void PrintUsage()
        {
            Console.WriteLine("DbCli - Command Line Interface for FIFA DB Master");
            Console.WriteLine("Usage: DbCli.exe <command> <db_path> <xml_path> [options]");
            Console.WriteLine();
            Console.WriteLine("Commands:");
            Console.WriteLine("  list-tables <db_path> <xml_path>                                     Lists all tables in the database");
            Console.WriteLine("  table-info <db_path> <xml_path> <table_name>                         Prints schema and count details for a table");
            Console.WriteLine("  export-table <db_path> <xml_path> <table_name> <output_file>         Exports a table to a tab-separated text file");
            Console.WriteLine("  import-table <db_path> <xml_path> <table_name> <input_file> <out_db>  Imports a table from a tab-separated text file");
            Console.WriteLine("  export-all <db_path> <xml_path> <output_dir>                         Exports all tables to a directory");
            Console.WriteLine("  import-all <db_path> <xml_path> <input_dir> <output_db_path>          Imports all tables from a directory and saves DB");
        }

        static void ListTables(string dbPath, string xmlPath)
        {
            Console.WriteLine("Loading Database...");
            DbFile db = new DbFile(dbPath, xmlPath);
            DataSet ds = db.ConvertToDataSet();
            Console.WriteLine($"Database loaded successfully. Number of tables: {ds.Tables.Count}");
            Console.WriteLine();
            Console.WriteLine("Tables:");
            foreach (DataTable table in ds.Tables)
            {
                Console.WriteLine($"  {table.TableName} ({table.Rows.Count} rows)");
            }
        }

        static void TableInfo(string dbPath, string xmlPath, string tableName)
        {
            Console.WriteLine("Loading Database...");
            DbFile db = new DbFile(dbPath, xmlPath);
            DataSet ds = db.ConvertToDataSet();
            DataTable table = ds.Tables[tableName];
            if (table == null)
            {
                Console.WriteLine($"ERROR: Table '{tableName}' not found in database.");
                return;
            }

            Console.WriteLine($"Table: {table.TableName}");
            Console.WriteLine($"Rows Count: {table.Rows.Count}");
            Console.WriteLine($"Columns Count: {table.Columns.Count}");
            Console.WriteLine();
            Console.WriteLine("Columns:");
            foreach (DataColumn col in table.Columns)
            {
                Console.WriteLine($"  {col.ColumnName} ({col.DataType.Name})");
            }
        }

        static void ExportTableCmd(string dbPath, string xmlPath, string tableName, string outputFile)
        {
            Console.WriteLine("Loading Database...");
            DbFile db = new DbFile(dbPath, xmlPath);
            DataSet ds = db.ConvertToDataSet();
            DataTable table = ds.Tables[tableName];
            if (table == null)
            {
                Console.WriteLine($"ERROR: Table '{tableName}' not found in database.");
                Environment.Exit(1);
            }

            Console.WriteLine($"Exporting table '{tableName}' to '{outputFile}'...");
            ExportTable(table, outputFile);
            Console.WriteLine("Export completed successfully.");
        }

        static void ImportTableCmd(string dbPath, string xmlPath, string tableName, string inputFile, string outputDbPath)
        {
            if (!File.Exists(inputFile))
            {
                Console.WriteLine($"ERROR: Input file not found: {inputFile}");
                Environment.Exit(1);
            }

            Console.WriteLine("Loading Database...");
            DbFile db = new DbFile(dbPath, xmlPath);
            DataSet ds = db.ConvertToDataSet();
            DataTable table = ds.Tables[tableName];
            if (table == null)
            {
                Console.WriteLine($"ERROR: Table '{tableName}' not found in database.");
                Environment.Exit(1);
            }

            Console.WriteLine($"Importing table '{tableName}' from '{inputFile}'...");
            if (!ImportTable(table, inputFile))
            {
                Console.WriteLine("ERROR: Import failed (column structure mismatch or empty file).");
                Environment.Exit(1);
            }

            Console.WriteLine("Rebuilding database file...");
            db.ConvertFromDataSet(ds);
            
            // Backup
            if (File.Exists(outputDbPath))
            {
                File.Copy(outputDbPath, outputDbPath + ".bak", true);
            }

            db.SaveDb(outputDbPath);
            // The schema XML is regenerated together with the DB (offsets/indices change); the game needs the matching pair.
            string outputXmlPath = outputDbPath.EndsWith(".DB", StringComparison.OrdinalIgnoreCase)
                ? outputDbPath.Substring(0, outputDbPath.Length - 3) + "-meta.XML"
                : outputDbPath + "-meta.xml";
            db.SaveXml(outputXmlPath);
            Console.WriteLine($"Saved matching meta XML to: {outputXmlPath}");
            Console.WriteLine($"Successfully imported table and saved database to: {outputDbPath}");
        }

        static void ExportAll(string dbPath, string xmlPath, string outputDir)
        {
            if (!Directory.Exists(outputDir))
            {
                Directory.CreateDirectory(outputDir);
            }

            Console.WriteLine("Loading Database...");
            DbFile db = new DbFile(dbPath, xmlPath);
            DataSet ds = db.ConvertToDataSet();
            Console.WriteLine($"Exporting all {ds.Tables.Count} tables to directory '{outputDir}'...");

            foreach (DataTable table in ds.Tables)
            {
                string filePath = Path.Combine(outputDir, table.TableName + ".txt");
                ExportTable(table, filePath);
                Console.WriteLine($"  Exported {table.TableName} ({table.Rows.Count} rows)");
            }
            Console.WriteLine("Export completed successfully.");
        }

        static void ImportAll(string dbPath, string xmlPath, string inputDir, string outputDbPath)
        {
            if (!Directory.Exists(inputDir))
            {
                Console.WriteLine($"ERROR: Input directory not found: {inputDir}");
                Environment.Exit(1);
            }

            Console.WriteLine("Loading Database...");
            DbFile db = new DbFile(dbPath, xmlPath);
            DataSet ds = db.ConvertToDataSet();

            string[] txtFiles = Directory.GetFiles(inputDir, "*.txt");
            if (txtFiles.Length == 0)
            {
                Console.WriteLine($"ERROR: No .txt files found in input directory: {inputDir}");
                Environment.Exit(1);
            }
            Console.WriteLine($"Found {txtFiles.Length} text files in directory. Importing...");

            int successCount = 0;
            foreach (string file in txtFiles)
            {
                string tableName = Path.GetFileNameWithoutExtension(file);
                DataTable table = ds.Tables[tableName];
                if (table != null)
                {
                    Console.WriteLine($"  Importing {tableName}...");
                    if (ImportTable(table, file))
                    {
                        successCount++;
                    }
                    else
                    {
                        Console.WriteLine($"  WARNING: Failed to import table {tableName}");
                    }
                }
            }

            if (successCount == 0)
            {
                Console.WriteLine("ERROR: No tables were successfully imported.");
                Environment.Exit(1);
            }

            Console.WriteLine($"Successfully imported {successCount} tables. Rebuilding and saving database...");
            db.ConvertFromDataSet(ds);
            
            // Backup
            if (File.Exists(outputDbPath))
            {
                File.Copy(outputDbPath, outputDbPath + ".bak", true);
            }

            db.SaveDb(outputDbPath);
            // The schema XML is regenerated together with the DB (offsets/indices change); the game needs the matching pair.
            string outputXmlPath = outputDbPath.EndsWith(".DB", StringComparison.OrdinalIgnoreCase)
                ? outputDbPath.Substring(0, outputDbPath.Length - 3) + "-meta.XML"
                : outputDbPath + "-meta.xml";
            db.SaveXml(outputXmlPath);
            Console.WriteLine($"Saved matching meta XML to: {outputXmlPath}");
            Console.WriteLine($"Successfully saved database to: {outputDbPath}");
        }

        static void ExportTable(DataTable t, string fileName)
        {
            using (StreamWriter streamWriter = new StreamWriter(fileName, false, Encoding.Unicode))
            {
                for (int i = 0; i < t.Columns.Count; i++)
                {
                    streamWriter.Write(t.Columns[i].ToString());
                    streamWriter.Write(i == t.Columns.Count - 1 ? "\r\n" : "\t");
                }
                for (int j = 0; j < t.Rows.Count; j++)
                {
                    for (int k = 0; k < t.Columns.Count; k++)
                    {
                        string text2 = t.Rows[j].ItemArray[k].ToString();
                        text2 = text2.Replace("\n", "\\n").Replace("\r", "\\r").Replace("\t", "\\t");
                        streamWriter.Write(text2);
                        streamWriter.Write(k == t.Columns.Count - 1 ? "\r\n" : "\t");
                    }
                }
            }
        }

        static Encoding DetectEncoding(string fileName)
        {
            using (FileStream fs = new FileStream(fileName, FileMode.Open, FileAccess.Read))
            {
                if (fs.Length >= 2)
                {
                    byte b0 = (byte)fs.ReadByte();
                    byte b1 = (byte)fs.ReadByte();
                    if (b0 == 0xFF && b1 == 0xFE) return Encoding.Unicode; // UTF-16 LE BOM
                    if (b0 == 0xFE && b1 == 0xFF) return Encoding.BigEndianUnicode;
                    if (b0 == 0xEF && b1 == 0xBB) return Encoding.UTF8;
                    if (b1 == 0x00) return Encoding.Unicode; // UTF-16 LE without BOM
                }
            }
            return Encoding.UTF8;
        }

        static bool ImportTable(DataTable t, string fileName)
        {
            Encoding enc = DetectEncoding(fileName);
            using (StreamReader streamReader = new StreamReader(fileName, enc))
            {
                string text = streamReader.ReadLine();
                if (text == null)
                {
                    return false;
                }
                int num = 1;
                for (int i = 0; i < text.Length; i++)
                {
                    if (text.Substring(i, 1) == "\t")
                    {
                        num++;
                    }
                }
                if (num != t.Columns.Count)
                {
                    return false;
                }
                string[] array = ReadCsv(text, num);
                for (int j = 0; j < array.Length; j++)
                {
                    if (array[j] != t.Columns[j].ColumnName)
                    {
                        return false;
                    }
                }
                t.Clear();
                t.BeginLoadData();
                while (streamReader.Peek() != -1)
                {
                    text = streamReader.ReadLine();
                    string[] array2 = ReadCsv(text, num);
                    DataRow dataRow = t.NewRow();
                    dataRow.ItemArray = array2;
                    t.Rows.Add(dataRow);
                }
                t.EndLoadData();
            }
            return true;
        }

        static string[] ReadCsv(string line, int nTokens)
        {
            string[] array = new string[nTokens];
            int num = 0;
            string text;
            for (int i = 0; i < nTokens - 1; i++)
            {
                int num2 = line.IndexOf("\t", num);
                int num3 = num2 - num;
                text = line.Substring(num, num3);
                num = num2 + 1;
                text = text.Replace("\\n", "\n").Replace("\\r", "\r").Replace("\\t", "\t");
                array[i] = text;
            }
            text = line.Substring(num);
            text = text.Replace("\\n", "\n").Replace("\\r", "\r").Replace("\\t", "\t");
            array[nTokens - 1] = text;
            return array;
        }
    }
}
