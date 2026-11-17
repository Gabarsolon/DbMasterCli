# DbMasterCli (DbCli)

A Command Line Interface (CLI) version of the classic FIFA **DB Master** utility. It allows developers and modders to inspect, export, and import tables in FIFA `.db` database files using a schema XML file.

Developed on top of the decompiled `FifaLibrary14` library.

---

## Features

- **List Tables**: Show all tables in the database and their record counts.
- **Table Info**: Show schema definition (columns and data types) for a specific table.
- **Export Single Table**: Export a table's records to a tab-separated `.tsv` / `.txt` file.
- **Import Single Table**: Load a tab-separated `.tsv` / `.txt` file into a table and rebuild/save the database.
- **Export All Tables**: Batch export all database tables to a target directory.
- **Import All Tables**: Batch import all tables from a directory and save the resulting database.
- **Auto-Encoding Detection**: Supports tab-separated files in UTF-16LE without BOM (pandas/Python output), UTF-8 (with or without BOM), and ANSI/ASCII.
- **Database Corruption Fix**: Patched `DbFile.cs` to ensure `ComputeAllCrc` calculates and writes checksums to the newly saved database file rather than corrupting the input database.
- **Strict Exit Codes**: Returns non-zero exit codes on failure for seamless pipeline automation.

---

## Building

Build using the .NET CLI:

```powershell
dotnet build -c Debug -p:Platform="AnyCPU"
```

*Note: The project automatically references `Microsoft.NETFramework.ReferenceAssemblies` via `Directory.Build.props` and includes dependencies from `ThirdParty`.*

---

## Usage

Run the executable `DbCli.exe` with one of the following commands:

### 1. List Tables
Lists all tables and their row counts:
```powershell
.\DbCli.exe list-tables <db_path> <xml_path>
```

### 2. Print Table Schema Info
```powershell
.\DbCli.exe table-info <db_path> <xml_path> <table_name>
```

### 3. Export a Single Table
```powershell
.\DbCli.exe export-table <db_path> <xml_path> <table_name> <output_tsv_file>
```

### 4. Import a Single Table
```powershell
.\DbCli.exe import-table <db_path> <xml_path> <table_name> <input_tsv_file> <output_db_path>
```

### 5. Export All Tables
```powershell
.\DbCli.exe export-all <db_path> <xml_path> <output_directory>
```

### 6. Import All Tables
```powershell
.\DbCli.exe import-all <db_path> <xml_path> <input_directory> <output_db_path>
```
